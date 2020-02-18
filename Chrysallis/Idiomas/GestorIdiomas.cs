using System;
namespace Chrysallis.Idiomas
{
    public static class GestorIdiomas
    {
        private static global::System.Resources.ResourceManager resourceMan;
        private static global::System.Globalization.CultureInfo resourceCulture;
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Chrysallis.Idiomas.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        internal static String getComunidad(String comunidad)
        {
             return ResourceManager.GetString(comunidad, resourceCulture);
        }
        

    }
}
