﻿#pragma checksum "..\..\..\AgregarAdmin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E310AB17C3EB4D96BA9074582E6D4829094CCA49"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using proyecto_final;


namespace proyecto_final {
    
    
    /// <summary>
    /// AgregarAdmin
    /// </summary>
    public partial class AgregarAdmin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\AgregarAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock bloqueUser;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\AgregarAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Usuario;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\AgregarAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock bloqueContraseña;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\AgregarAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox email;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\AgregarAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Confim_contr;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\AgregarAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Contraseña;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\AgregarAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button confirmar;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\AgregarAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button salir;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/proyecto_final;component/agregaradmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AgregarAdmin.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.bloqueUser = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Usuario = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\..\AgregarAdmin.xaml"
            this.Usuario.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Usuario_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.bloqueContraseña = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.email = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\AgregarAdmin.xaml"
            this.email.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Email_TextChanged3);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Confim_contr = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\AgregarAdmin.xaml"
            this.Confim_contr.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Confirmar_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Contraseña = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\AgregarAdmin.xaml"
            this.Contraseña.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Contrasenia_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.confirmar = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\AgregarAdmin.xaml"
            this.confirmar.Click += new System.Windows.RoutedEventHandler(this.confirmar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.salir = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\AgregarAdmin.xaml"
            this.salir.Click += new System.Windows.RoutedEventHandler(this.salir_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
