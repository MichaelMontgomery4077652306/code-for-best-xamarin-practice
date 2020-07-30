using System;
using System.ComponentModel;
using TruliteMobile.Effects;
using TruliteMobile.IOS.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Material.iOS;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("TruliteMobile")]
[assembly: ExportEffect(typeof(MaterialEntryEffect), "MaterialEntryEffect")]
namespace TruliteMobile.IOS.Effects
{
    public class MaterialEntryEffect : PlatformEffect
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
            MaterialTextField materialTextField = Control as MaterialTextField;
            if (materialTextField != null) {
                materialTextField.ActiveTextInputController.SetErrorText(MaterialEntryExtensionEffect.GetErrorText(Element), null);
            }
        }

        void UpdateHelperText()
        {
            MaterialTextField materialTextField = Control as MaterialTextField;
            if (materialTextField != null)
            {
                materialTextField.ActiveTextInputController.SetHelperText (MaterialEntryExtensionEffect.GetHelperText(Element), null);
            }
        }

    }
}
