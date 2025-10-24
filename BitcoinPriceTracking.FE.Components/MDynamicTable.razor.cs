using BitcoinPriceTracking.FE.Components.Interfaces;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace BitcoinPriceTracking.FE.Components
{
	public partial class MDynamicTable<T>
	{
		private HashSet<string> _expanded = new();
		private Dictionary<string, string?> _validationErrors = new();
		private Dictionary<string, string> FilterTexts = new();
		[Parameter] public List<string>? ColumnOrder { get; set; }
		[Parameter] public Dictionary<string, string>? ColumnWidths { get; set; }
		[Parameter] public bool IsButtonDelete { get; set; }
		[Parameter] public bool IsButtonSave { get; set; }
		[Parameter] public IEnumerable<T>? Items { get; set; }
		[Parameter] public EventCallback<T> OnDelete { get; set; }
		[Parameter] public EventCallback<T> OnSave { get; set; }
		[Parameter] public bool SortAscending { get; set; } = true;
		[Parameter] public string? SortColumn { get; set; }
		private PropertyInfo[] props { get => getPropertiesInOrder(); }

		public static bool IsPropertyEditable<T>(string propertyName)
		{
			var prop = typeof(T).GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);
			if (prop == null)
				return false;

			var attr = prop.GetCustomAttribute<EditableAttribute>();
			return attr?.AllowEdit ?? false;
		}

		private IEnumerable<T> applySortingAndFiltering(IEnumerable<T>? items, PropertyInfo[] props)
		{
			if (items == null)
				return Enumerable.Empty<T>();

			var result = items;

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

		private string getFilterValue(string propName)
			=> FilterTexts.TryGetValue(propName, out var v) ? v : "";

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

		protected override void OnParametersSet()
		{
			base.OnParametersSet();

			if (Items != null)
			{
				foreach (var item in Items)
				{
					validationPropsAndUpdateError(item);
				}
			}
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

		private bool isItemValid(T item)
		{
			return !_validationErrors.Keys.Any(k => k.StartsWith(item.GetHashCode().ToString()));
		}

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
			if (itemMod != null)
				itemMod.IsEdit = true;
			validationPropsAndUpdateError(item);
		}

		private void onFilterChanged(string propName, string? value)
		{
			if (string.IsNullOrWhiteSpace(value))
				FilterTexts.Remove(propName);
			else
				FilterTexts[propName] = value;

			StateHasChanged();
		}

		private void onInputChanged(T item, PropertyInfo prop, string? newValue)
		{
			setPropertyValue(item, prop, newValue);
			validationAndUpdateError(item, prop);
		}

		private async Task onSaveClicked(T item)
		{
			if (!validateItem(item))
			{
				StateHasChanged();
				return;
			}

			if (OnSave.HasDelegate)
			{
				await OnSave.InvokeAsync(item);
				var itemMod = (IDynamicTableItem)item;
				if (itemMod != null)
					itemMod.IsEdit = false;
			}
		}

		private void setPropertyValue(T item, PropertyInfo prop, string? newValue)
		{
			try
			{
				object? converted = null;
				if (prop.PropertyType == typeof(string))
					converted = newValue;
				else if (prop.PropertyType == typeof(int))
					converted = int.TryParse(newValue, out var i) ? i : 0;
				else if (prop.PropertyType == typeof(double))
					converted = double.TryParse(newValue, out var d) ? d : 0;
				else if (prop.PropertyType == typeof(decimal))
					converted = decimal.TryParse(newValue, out var m) ? m : 0;
				else if (prop.PropertyType == typeof(DateTime))
					converted = DateTime.TryParse(newValue, out var dt) ? dt : default;

				prop.SetValue(item, converted);
			}
			catch { }
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

		private bool validateItem(T item)
		{
			_validationErrors.Clear();
			var context = new ValidationContext(item);
			var results = new List<ValidationResult>();

			bool isValid = Validator.TryValidateObject(item, context, results, true);

			foreach (var result in results)
			{
				if (result.MemberNames.FirstOrDefault() is string member)
					_validationErrors[member] = result.ErrorMessage;
			}

			return isValid;
		}

		private void validationAndUpdateError(T item, PropertyInfo prop)
		{
			var key = $"{item.GetHashCode()}_{prop.Name}";
			_validationErrors.Remove(key);

			var context = new ValidationContext(item)
			{
				MemberName = prop.Name
			};

			var results = new List<ValidationResult>();
			var value = prop.GetValue(item);

			if (!Validator.TryValidateProperty(value, context, results))
			{
				_validationErrors[key] = results.First().ErrorMessage;
			}

			StateHasChanged();
		}

		private void validationPropsAndUpdateError(T item)
		{
			foreach (var prop in props)
			{
				validationAndUpdateError(item, prop);
			}

			StateHasChanged();
		}
	}
}
