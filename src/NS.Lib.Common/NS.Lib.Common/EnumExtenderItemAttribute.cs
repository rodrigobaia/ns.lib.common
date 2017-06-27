namespace NS.Lib.Common
{
    //   /// <summary>
    ///// Atributo para Enums, é possível com esse atributo criar um descritivo para cada enum e capturar o mesmo em um array.
    ///// </summary>
    //[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    //   public class EnumExtenderItemAttribute : Attribute
    //   {
    //       private string _description;
    //       private string _extendedValue;
    //       private string _resourceKey;
    //       private Type _resourceType;

    //       /// <summary>
    //       /// 
    //       /// </summary>
    //       /// <param name="description"></param>
    //       public EnumExtenderItemAttribute(string description)
    //       {
    //           initialize(string.Empty, description, null, null);
    //       }

    //       /// <summary>
    //       /// 
    //       /// </summary>
    //       /// <param name="extendedValue"></param>
    //       /// <param name="description"></param>
    //       public EnumExtenderItemAttribute(string extendedValue, string description)
    //       {
    //           initialize(extendedValue, description, null, null);
    //       }

    //       /// <summary>
    //       /// 
    //       /// </summary>
    //       /// <param name="resourceKey"></param>
    //       /// <param name="resouceType"></param>
    //       public EnumExtenderItemAttribute(string resourceKey, Type resouceType)
    //       {
    //           initialize(string.Empty, null, resourceKey, resouceType);
    //       }

    //       /// <summary>
    //       /// 
    //       /// </summary>
    //       /// <param name="extendedValue"></param>
    //       /// <param name="resourceKey"></param>
    //       /// <param name="resouceType"></param>
    //       public EnumExtenderItemAttribute(string extendedValue, string resourceKey, Type resouceType)
    //       {
    //           initialize(extendedValue, null, resourceKey, resouceType);
    //       }

    //       private void initialize(string extendedValue, string description, string resourceKey, Type resouceType)
    //       {
    //           _extendedValue = extendedValue;
    //           _description = description;
    //           _resourceKey = resourceKey;
    //           _resourceType = resouceType;
    //       }

    //       internal string GetDescription()
    //       {
    //           string result = _description;

    //           if (_resourceType != null && !string.IsNullOrEmpty(_resourceKey))
    //           {
    //               PropertyInfo propertyInfo = _resourceType.GetProperty(_resourceKey, BindingFlags.GetProperty | BindingFlags.NonPublic | BindingFlags.Static);
    //               if (propertyInfo != null)
    //                   result = (string)propertyInfo.GetValue(null, null);
    //           }

    //           return result;
    //       }

    //       internal string GetExtendedValue()
    //       {
    //           return _extendedValue;
    //       }
    //   }
}
