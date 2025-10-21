using BitcoinPriceTracking.FE.Components.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinPriceTracking.FE.Components
{
    public partial class MDynamicTable<T>
    {
		private HashSet<string> _expanded = new();
		private Dictionary<string, string> FilterTexts = new();
		[Parameter] public List<string>? ColumnOrder { get; set; }
		[Parameter] public Dictionary<string, string>? ColumnWidths { get; set; }
		[Parameter] public bool IsButtonDelete { get; set; }
		[Parameter] public bool IsButtonSave { get; set; }
		[Parameter] public T? Item { get; set; }
		[Parameter] public IEnumerable<T>? Items { get; set; }
		[Parameter] public EventCallback<T> OnDelete { get; set; }
		[Parameter] public EventCallback<T> OnSave { get; set; }
		[Parameter] public bool SortAscending { get; set; } = true;
		[Parameter] public string? SortColumn { get; set; }
		public static IEnumerable<PropertyInfo> GetEditableProperties<T>()
		{
			return typeof(T)
				.GetProperties(BindingFlags.Public | BindingFlags.Instance)
				.Where(p =>
				{
					var attr = p.GetCustomAttribute<EditableAttribute>();
					return attr?.AllowEdit ?? false; // když atribut chybí, bereme jako editovatelné
				});
		}

		public static bool IsPropertyEditable<T>(string propertyName)
		{
			var prop = typeof(T).GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);
			if (prop == null)
				return false;

			var attr = prop.GetCustomAttribute<EditableAttribute>();
			return attr?.AllowEdit ?? false; // když atribut chybí, bereme jako editovatelné
		}

		private IEnumerable<T> ApplySortingAndFiltering(IEnumerable<T>? items, PropertyInfo[] props)
		{
			if (items == null)
				return Enumerable.Empty<T>();

			var result = items;

			// Filtrování
			foreach (var filter in FilterTexts)
			{
				var prop = props.FirstOrDefault(p => p.Name == filter.Key && isFilterable(p));
				if (prop != null && !string.IsNullOrWhiteSpace(filter.Value))
				{
					string text = filter.Value.ToLowerInvariant();
					result = result.Where(item =>
					{
						var val = prop.GetValue(item);
						return val != null && val.ToString()!.ToLowerInvariant().Contains(text);
					});
				}
			}

			// Řazení
			if (!string.IsNullOrEmpty(SortColumn))
			{
				var prop = props.FirstOrDefault(p => p.Name == SortColumn && isSortable(p));
				if (prop != null)
				{
					result = SortAscending
						? result.OrderBy(item => prop.GetValue(item))
						: result.OrderByDescending(item => prop.GetValue(item));
				}
			}

			return result;
		}

		private string GetFilterValue(string propName)
			=> FilterTexts.TryGetValue(propName, out var v) ? v : string.Empty;

		private PropertyInfo[] getPropertiesInOrder()
		{
			var allProps = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

			if (ColumnOrder == null || ColumnOrder.Count == 0)
				return allProps;

			return ColumnOrder
				.Select(name => allProps.FirstOrDefault(p => p.Name == name))
				.Where(p => p != null)
				.Cast<PropertyInfo>()
				.ToArray();
		}

		private string getPropertyValueAsString(object item, PropertyInfo prop)
		{
			var value = prop.GetValue(item);
			return value?.ToString() ?? string.Empty;
		}

		private string getWidthStyle(string propName)
		{
			if (ColumnWidths != null && ColumnWidths.TryGetValue(propName, out var width))
				return $"width:{width};";
			return "";
		}

		private bool isEdit(T item)
		{
			var conMod = (IDynamicTableItem)item;
			return conMod.IsEdit;
		}

		private bool isExpanded(string key) => _expanded.Contains(key);

		private bool isFilterable(PropertyInfo prop) => isSortable(prop);

		private bool isSortable(PropertyInfo prop)
		{
			var type = prop.PropertyType;
			return type.IsPrimitive || type == typeof(string) || type == typeof(DateTime) || type == typeof(decimal);
		}

		private async Task onDeleteClicked(T item)
		{
			if (OnDelete.HasDelegate)
				await OnDelete.InvokeAsync(item);
		}

		private async Task onEditClicked(T item)
		{
			var itemMod = (IDynamicTableItem)item;
			itemMod.IsEdit = true;
		}

		private void OnFilterChanged(string propName, string? value)
		{
			if (string.IsNullOrWhiteSpace(value))
				FilterTexts.Remove(propName);
			else
				FilterTexts[propName] = value;

			StateHasChanged();
		}

		private async Task onSaveClicked(T item)
		{
			if (OnSave.HasDelegate)
			{
				await OnSave.InvokeAsync(item);
				var itemMod = (IDynamicTableItem)item;
				itemMod.IsEdit = false;
			}
		}

		private void setPropertyValue(object item, PropertyInfo prop, string newValue)
		{
			if (prop.PropertyType == typeof(string))
			{
				prop.SetValue(item, newValue);
			}
			else if (prop.PropertyType == typeof(int))
			{
				if (int.TryParse(newValue, out int intValue))
					prop.SetValue(item, intValue);
			}
			else if (prop.PropertyType == typeof(double))
			{
				if (double.TryParse(newValue, out double dblValue))
					prop.SetValue(item, dblValue);
			}
			// další typy podle potřeby
		}
		private void toggle(string key)
		{
			if (!_expanded.Add(key))
				_expanded.Remove(key);
		}
		private void toggleSort(string column)
		{
			var prop = getPropertiesInOrder().FirstOrDefault(p => p.Name == column);
			if (prop == null || !isSortable(prop))
				return;

			if (SortColumn == column)
				SortAscending = !SortAscending;
			else
			{
				SortColumn = column;
				SortAscending = true;
			}
		}
	}
}
