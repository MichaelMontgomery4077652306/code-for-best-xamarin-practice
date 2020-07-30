using System;
using System.ComponentModel;
using TruliteMobile.Droid.Effects;
using TruliteMobile.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Material.Android;
using Xamarin.Forms.Platform.Android;

//[assembly: ResolutionGroupName("TruliteMobile")]
[assembly: ExportEffect(typeof(MaterialPickerEffect), "MaterialPickerEffect")]
namespace TruliteMobile.Droid.Effects
{
    public class MaterialPickerEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                UpdateErrorText();
                UpdateHelperText();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }

        protected override void OnDetached()
        {
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            if (args.PropertyName == MaterialEntryExtensionEffect.ErrorTextProperty.PropertyName)
            {
                UpdateErrorText();
            }
            else if (args.PropertyName == MaterialEntryExtensionEffect.HelperTextProperty.PropertyName)
            {
                UpdateHelperText();
            }
        }

        void UpdateErrorText()
        {
            MaterialPickerTextInputLayout materialPickerTextInputLayout = Control as MaterialPickerTextInputLayout;
            if (materialPickerTextInputLayout != null) {
                materialPickerTextInputLayout.Error = MaterialEntryExtensionEffect.GetErrorText(Element);
            }
        }

        void UpdateHelperText()
        {
            MaterialPickerTextInputLayout materialPickerTextInputLayout = Control as MaterialPickerTextInputLayout;
            if (materialPickerTextInputLayout != null)
            {
                materialPickerTextInputLayout.HelperText = MaterialEntryExtensionEffect.GetHelperText(Element);
            }
        }

    }
}
