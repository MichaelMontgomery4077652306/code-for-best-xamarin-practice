using System;
using System.Linq;
using Xamarin.Forms;

namespace TruliteMobile.Effects
{
   
    public static class MaterialEntryExtensionEffect
    {
        public static readonly BindableProperty HasMaterialEntryProperty = BindableProperty.CreateAttached("HasMaterialEntry", typeof(bool), typeof(MaterialEntryExtensionEffect), false, propertyChanged: OnHasMaterialEntryChanged);
        public static readonly BindableProperty ErrorTextProperty = BindableProperty.CreateAttached("ErrorText", typeof(String), typeof(MaterialEntryExtensionEffect), default(String));
        public static readonly BindableProperty HelperTextProperty = BindableProperty.CreateAttached("HelperText", typeof(String), typeof(MaterialEntryExtensionEffect), default(String));
        
        public static bool GetHasMaterialEntry(BindableObject view)
        {
            return (bool)view.GetValue(HasMaterialEntryProperty);
        }

        public static void SetHasMaterialEntry(BindableObject view, bool value)
        {
            view.SetValue(HasMaterialEntryProperty, value);
        }

        public static String GetErrorText(BindableObject view)
        {
            return (String)view.GetValue(ErrorTextProperty);
        }

        public static void SetErrorText(BindableObject view, String value)
        {
            view.SetValue(ErrorTextProperty, value);
        }

        public static String GetHelperText(BindableObject view)
        {
            return (String)view.GetValue(HelperTextProperty);
        }

        public static void SetHelperText(BindableObject view, String value)
        {
            view.SetValue(HelperTextProperty, value);
        }

        static void OnHasMaterialEntryChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var view = bindable as View;
            if (view == null)
            {
                return;
            }

            bool hasShadow = (bool)newValue;
            if (view is Entry)
            {
                if (hasShadow)
                {
                    view.Effects.Add(new MaterialEntryEffect());
                }
                else
                {
                    var toRemove = view.Effects.FirstOrDefault(e => e is MaterialEntryEffect);
                    if (toRemove != null)
                    {
                        view.Effects.Remove(toRemove);
                    }
                }
            }
            else if (view is Picker)
            {
                if (hasShadow)
                {
                    view.Effects.Add(new MaterialPickerEffect());
                }
                else
                {
                    var toRemove = view.Effects.FirstOrDefault(e => e is MaterialPickerEffect);
                    if (toRemove != null)
                    {
                        view.Effects.Remove(toRemove);
                    }
                }
            }
            
        }

        class MaterialEntryEffect : RoutingEffect
        {
            public MaterialEntryEffect() : base("TruliteMobile.MaterialEntryEffect")
            {
            }
        }

        class MaterialPickerEffect : RoutingEffect
        {
            public MaterialPickerEffect() : base("TruliteMobile.MaterialPickerEffect")
            {
            }
        }
    }
}
