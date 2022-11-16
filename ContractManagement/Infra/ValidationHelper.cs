using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractManagement.Infra
{
	internal class ValidationHelper
	{
		public static bool Validate<T>(T model,
										Dictionary<string, Control> map,
										ErrorProvider errorProvider)
		{
			ValidationContext context = new ValidationContext(model, null, null);
			List<ValidationResult> errors = new List<ValidationResult>();
			errorProvider.Clear();
			bool validateAllProperties = true;
			bool isValid = Validator.TryValidateObject(model, context, errors, validateAllProperties);
			if (!isValid)
			{
				DisplayErrorsByErrorProvider(errors, map, errorProvider);
			}
			return isValid;
		}
		private static void DisplayErrorsByErrorProvider(List<ValidationResult> errors,
															Dictionary<string, Control> map,
															ErrorProvider errorProvider)
		{
			foreach (ValidationResult error in errors)
			{
				string propName = error.MemberNames.FirstOrDefault();
				if (map.TryGetValue(propName, out Control ctrl))
				{
					errorProvider.SetError(ctrl, error.ErrorMessage);
				}
			}
		}
	}
}
