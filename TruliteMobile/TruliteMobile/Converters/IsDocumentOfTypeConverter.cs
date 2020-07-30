using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using TruliteMobile.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Converters
{
    /// <summary>
    /// Returns if a certain document is of the type passed in as a parameter
    /// this is used to differentiate PDF files (that can be opened in the PDF Viewer control)
    /// from other document types that will probably be opened using other control or using the
    /// OS to do so.
    /// </summary>
    public class IsDocumentOfTypeConverter: IMarkupExtension,IValueConverter
    {
        private static IsDocumentOfTypeConverter _instance;
        public static IsDocumentOfTypeConverter Instance => _instance ?? (_instance = new IsDocumentOfTypeConverter());
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Instance;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var doc =  value as DocumentUploadView;
            if (doc == null) return false;
            if (parameter == null) return false;
            var documentType = (DocumentTypeEnum)parameter;
            switch (documentType)
            {
                case DocumentTypeEnum.Any:
                    return true;
                    break;
                case DocumentTypeEnum.PDF:
                    return doc.OriginalName.ToLowerInvariant().EndsWith(".pdf");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public enum DocumentTypeEnum
    {
        Any,
        PDF,
       
    }
}
