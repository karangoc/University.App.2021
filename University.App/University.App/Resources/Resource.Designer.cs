﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace University.App.Resources {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("University.App.Resources.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Accept.
        /// </summary>
        internal static string Accept {
            get {
                return ResourceManager.GetString("Accept", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a The fields are required.
        /// </summary>
        internal static string FieldsRequired {
            get {
                return ResourceManager.GetString("FieldsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Login.
        /// </summary>
        internal static string Login {
            get {
                return ResourceManager.GetString("Login", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Don´t have an account? Sign Up.
        /// </summary>
        internal static string LoginPageDontHaveAccount {
            get {
                return ResourceManager.GetString("LoginPageDontHaveAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a login or member from here to access.
        /// </summary>
        internal static string LoginPageLoginMember {
            get {
                return ResourceManager.GetString("LoginPageLoginMember", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a No Internet Connection.
        /// </summary>
        internal static string NoInternetConnection {
            get {
                return ResourceManager.GetString("NoInternetConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Notification.
        /// </summary>
        internal static string Notification {
            get {
                return ResourceManager.GetString("Notification", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a University.
        /// </summary>
        internal static string University {
            get {
                return ResourceManager.GetString("University", resourceCulture);
            }
        }
    }
}