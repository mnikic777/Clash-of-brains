﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/PPIJServiceWebRole")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Pitanje", Namespace="http://schemas.datacontract.org/2004/07/PPIJServiceWebRole")]
    [System.SerializableAttribute()]
    public partial class Pitanje : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_kategorijeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_odgovoraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_pitanjaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_tipa_odgovoraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string opis_podrucjaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string slika_pitanjaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tekst_pitanjaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_kategorije {
            get {
                return this.id_kategorijeField;
            }
            set {
                if ((this.id_kategorijeField.Equals(value) != true)) {
                    this.id_kategorijeField = value;
                    this.RaisePropertyChanged("id_kategorije");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_odgovora {
            get {
                return this.id_odgovoraField;
            }
            set {
                if ((this.id_odgovoraField.Equals(value) != true)) {
                    this.id_odgovoraField = value;
                    this.RaisePropertyChanged("id_odgovora");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_pitanja {
            get {
                return this.id_pitanjaField;
            }
            set {
                if ((this.id_pitanjaField.Equals(value) != true)) {
                    this.id_pitanjaField = value;
                    this.RaisePropertyChanged("id_pitanja");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_tipa_odgovora {
            get {
                return this.id_tipa_odgovoraField;
            }
            set {
                if ((this.id_tipa_odgovoraField.Equals(value) != true)) {
                    this.id_tipa_odgovoraField = value;
                    this.RaisePropertyChanged("id_tipa_odgovora");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string opis_podrucja {
            get {
                return this.opis_podrucjaField;
            }
            set {
                if ((object.ReferenceEquals(this.opis_podrucjaField, value) != true)) {
                    this.opis_podrucjaField = value;
                    this.RaisePropertyChanged("opis_podrucja");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string slika_pitanja {
            get {
                return this.slika_pitanjaField;
            }
            set {
                if ((object.ReferenceEquals(this.slika_pitanjaField, value) != true)) {
                    this.slika_pitanjaField = value;
                    this.RaisePropertyChanged("slika_pitanja");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tekst_pitanja {
            get {
                return this.tekst_pitanjaField;
            }
            set {
                if ((object.ReferenceEquals(this.tekst_pitanjaField, value) != true)) {
                    this.tekst_pitanjaField = value;
                    this.RaisePropertyChanged("tekst_pitanja");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MapaOdgovor", Namespace="http://schemas.datacontract.org/2004/07/PPIJServiceWebRole")]
    [System.SerializableAttribute()]
    public partial class MapaOdgovor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string drzavaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_odgovoraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_pitanjaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_tipa_odgovoraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double koordinata_xField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double koordinata_yField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string drzava {
            get {
                return this.drzavaField;
            }
            set {
                if ((object.ReferenceEquals(this.drzavaField, value) != true)) {
                    this.drzavaField = value;
                    this.RaisePropertyChanged("drzava");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_odgovora {
            get {
                return this.id_odgovoraField;
            }
            set {
                if ((this.id_odgovoraField.Equals(value) != true)) {
                    this.id_odgovoraField = value;
                    this.RaisePropertyChanged("id_odgovora");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_pitanja {
            get {
                return this.id_pitanjaField;
            }
            set {
                if ((this.id_pitanjaField.Equals(value) != true)) {
                    this.id_pitanjaField = value;
                    this.RaisePropertyChanged("id_pitanja");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_tipa_odgovora {
            get {
                return this.id_tipa_odgovoraField;
            }
            set {
                if ((this.id_tipa_odgovoraField.Equals(value) != true)) {
                    this.id_tipa_odgovoraField = value;
                    this.RaisePropertyChanged("id_tipa_odgovora");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double koordinata_x {
            get {
                return this.koordinata_xField;
            }
            set {
                if ((this.koordinata_xField.Equals(value) != true)) {
                    this.koordinata_xField = value;
                    this.RaisePropertyChanged("koordinata_x");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double koordinata_y {
            get {
                return this.koordinata_yField;
            }
            set {
                if ((this.koordinata_yField.Equals(value) != true)) {
                    this.koordinata_yField = value;
                    this.RaisePropertyChanged("koordinata_y");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SlikaOdgovor", Namespace="http://schemas.datacontract.org/2004/07/PPIJServiceWebRole")]
    [System.SerializableAttribute()]
    public partial class SlikaOdgovor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int broj_tocnog_odgovoraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_odgovoraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_pitanjaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_tipa_odgovoraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string slika_1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string slika_2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string slika_3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string slika_4Field;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int broj_tocnog_odgovora {
            get {
                return this.broj_tocnog_odgovoraField;
            }
            set {
                if ((this.broj_tocnog_odgovoraField.Equals(value) != true)) {
                    this.broj_tocnog_odgovoraField = value;
                    this.RaisePropertyChanged("broj_tocnog_odgovora");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_odgovora {
            get {
                return this.id_odgovoraField;
            }
            set {
                if ((this.id_odgovoraField.Equals(value) != true)) {
                    this.id_odgovoraField = value;
                    this.RaisePropertyChanged("id_odgovora");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_pitanja {
            get {
                return this.id_pitanjaField;
            }
            set {
                if ((this.id_pitanjaField.Equals(value) != true)) {
                    this.id_pitanjaField = value;
                    this.RaisePropertyChanged("id_pitanja");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_tipa_odgovora {
            get {
                return this.id_tipa_odgovoraField;
            }
            set {
                if ((this.id_tipa_odgovoraField.Equals(value) != true)) {
                    this.id_tipa_odgovoraField = value;
                    this.RaisePropertyChanged("id_tipa_odgovora");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string slika_1 {
            get {
                return this.slika_1Field;
            }
            set {
                if ((object.ReferenceEquals(this.slika_1Field, value) != true)) {
                    this.slika_1Field = value;
                    this.RaisePropertyChanged("slika_1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string slika_2 {
            get {
                return this.slika_2Field;
            }
            set {
                if ((object.ReferenceEquals(this.slika_2Field, value) != true)) {
                    this.slika_2Field = value;
                    this.RaisePropertyChanged("slika_2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string slika_3 {
            get {
                return this.slika_3Field;
            }
            set {
                if ((object.ReferenceEquals(this.slika_3Field, value) != true)) {
                    this.slika_3Field = value;
                    this.RaisePropertyChanged("slika_3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string slika_4 {
            get {
                return this.slika_4Field;
            }
            set {
                if ((object.ReferenceEquals(this.slika_4Field, value) != true)) {
                    this.slika_4Field = value;
                    this.RaisePropertyChanged("slika_4");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TekstOdgovor", Namespace="http://schemas.datacontract.org/2004/07/PPIJServiceWebRole")]
    [System.SerializableAttribute()]
    public partial class TekstOdgovor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int broj_tocnog_odgovoraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_odgovoraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_pitanjaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_tipa_odgovoraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tekst_1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tekst_2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tekst_3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tekst_4Field;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int broj_tocnog_odgovora {
            get {
                return this.broj_tocnog_odgovoraField;
            }
            set {
                if ((this.broj_tocnog_odgovoraField.Equals(value) != true)) {
                    this.broj_tocnog_odgovoraField = value;
                    this.RaisePropertyChanged("broj_tocnog_odgovora");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_odgovora {
            get {
                return this.id_odgovoraField;
            }
            set {
                if ((this.id_odgovoraField.Equals(value) != true)) {
                    this.id_odgovoraField = value;
                    this.RaisePropertyChanged("id_odgovora");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_pitanja {
            get {
                return this.id_pitanjaField;
            }
            set {
                if ((this.id_pitanjaField.Equals(value) != true)) {
                    this.id_pitanjaField = value;
                    this.RaisePropertyChanged("id_pitanja");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_tipa_odgovora {
            get {
                return this.id_tipa_odgovoraField;
            }
            set {
                if ((this.id_tipa_odgovoraField.Equals(value) != true)) {
                    this.id_tipa_odgovoraField = value;
                    this.RaisePropertyChanged("id_tipa_odgovora");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tekst_1 {
            get {
                return this.tekst_1Field;
            }
            set {
                if ((object.ReferenceEquals(this.tekst_1Field, value) != true)) {
                    this.tekst_1Field = value;
                    this.RaisePropertyChanged("tekst_1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tekst_2 {
            get {
                return this.tekst_2Field;
            }
            set {
                if ((object.ReferenceEquals(this.tekst_2Field, value) != true)) {
                    this.tekst_2Field = value;
                    this.RaisePropertyChanged("tekst_2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tekst_3 {
            get {
                return this.tekst_3Field;
            }
            set {
                if ((object.ReferenceEquals(this.tekst_3Field, value) != true)) {
                    this.tekst_3Field = value;
                    this.RaisePropertyChanged("tekst_3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tekst_4 {
            get {
                return this.tekst_4Field;
            }
            set {
                if ((object.ReferenceEquals(this.tekst_4Field, value) != true)) {
                    this.tekst_4Field = value;
                    this.RaisePropertyChanged("tekst_4");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IPPIJCloudService")]
    public interface IPPIJCloudService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPPIJCloudService/GetData", ReplyAction="http://tempuri.org/IPPIJCloudService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPPIJCloudService/GetData", ReplyAction="http://tempuri.org/IPPIJCloudService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPPIJCloudService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IPPIJCloudService/GetDataUsingDataContractResponse")]
        ConsoleApplication1.ServiceReference1.CompositeType GetDataUsingDataContract(ConsoleApplication1.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPPIJCloudService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IPPIJCloudService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(ConsoleApplication1.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPPIJCloudService/GetPitanjeByID", ReplyAction="http://tempuri.org/IPPIJCloudService/GetPitanjeByIDResponse")]
        ConsoleApplication1.ServiceReference1.Pitanje GetPitanjeByID(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPPIJCloudService/GetPitanjeByID", ReplyAction="http://tempuri.org/IPPIJCloudService/GetPitanjeByIDResponse")]
        System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.Pitanje> GetPitanjeByIDAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPPIJCloudService/GetMapaOdgovorByIDpitanja", ReplyAction="http://tempuri.org/IPPIJCloudService/GetMapaOdgovorByIDpitanjaResponse")]
        ConsoleApplication1.ServiceReference1.MapaOdgovor GetMapaOdgovorByIDpitanja(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPPIJCloudService/GetMapaOdgovorByIDpitanja", ReplyAction="http://tempuri.org/IPPIJCloudService/GetMapaOdgovorByIDpitanjaResponse")]
        System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.MapaOdgovor> GetMapaOdgovorByIDpitanjaAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPPIJCloudService/GetSlikaOdgovorByIDpitanja", ReplyAction="http://tempuri.org/IPPIJCloudService/GetSlikaOdgovorByIDpitanjaResponse")]
        ConsoleApplication1.ServiceReference1.SlikaOdgovor GetSlikaOdgovorByIDpitanja(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPPIJCloudService/GetSlikaOdgovorByIDpitanja", ReplyAction="http://tempuri.org/IPPIJCloudService/GetSlikaOdgovorByIDpitanjaResponse")]
        System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.SlikaOdgovor> GetSlikaOdgovorByIDpitanjaAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPPIJCloudService/GetTekstOdgovorByIDpitanja", ReplyAction="http://tempuri.org/IPPIJCloudService/GetTekstOdgovorByIDpitanjaResponse")]
        ConsoleApplication1.ServiceReference1.TekstOdgovor GetTekstOdgovorByIDpitanja(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPPIJCloudService/GetTekstOdgovorByIDpitanja", ReplyAction="http://tempuri.org/IPPIJCloudService/GetTekstOdgovorByIDpitanjaResponse")]
        System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.TekstOdgovor> GetTekstOdgovorByIDpitanjaAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPPIJCloudService/GetPitanjaByIDkategorije", ReplyAction="http://tempuri.org/IPPIJCloudService/GetPitanjaByIDkategorijeResponse")]
        ConsoleApplication1.ServiceReference1.Pitanje GetPitanjaByIDkategorije(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPPIJCloudService/GetPitanjaByIDkategorije", ReplyAction="http://tempuri.org/IPPIJCloudService/GetPitanjaByIDkategorijeResponse")]
        System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.Pitanje> GetPitanjaByIDkategorijeAsync(int ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPPIJCloudServiceChannel : ConsoleApplication1.ServiceReference1.IPPIJCloudService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PPIJCloudServiceClient : System.ServiceModel.ClientBase<ConsoleApplication1.ServiceReference1.IPPIJCloudService>, ConsoleApplication1.ServiceReference1.IPPIJCloudService {
        
        public PPIJCloudServiceClient() {
        }
        
        public PPIJCloudServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PPIJCloudServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PPIJCloudServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PPIJCloudServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public ConsoleApplication1.ServiceReference1.CompositeType GetDataUsingDataContract(ConsoleApplication1.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(ConsoleApplication1.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public ConsoleApplication1.ServiceReference1.Pitanje GetPitanjeByID(int ID) {
            return base.Channel.GetPitanjeByID(ID);
        }
        
        public System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.Pitanje> GetPitanjeByIDAsync(int ID) {
            return base.Channel.GetPitanjeByIDAsync(ID);
        }
        
        public ConsoleApplication1.ServiceReference1.MapaOdgovor GetMapaOdgovorByIDpitanja(int ID) {
            return base.Channel.GetMapaOdgovorByIDpitanja(ID);
        }
        
        public System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.MapaOdgovor> GetMapaOdgovorByIDpitanjaAsync(int ID) {
            return base.Channel.GetMapaOdgovorByIDpitanjaAsync(ID);
        }
        
        public ConsoleApplication1.ServiceReference1.SlikaOdgovor GetSlikaOdgovorByIDpitanja(int ID) {
            return base.Channel.GetSlikaOdgovorByIDpitanja(ID);
        }
        
        public System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.SlikaOdgovor> GetSlikaOdgovorByIDpitanjaAsync(int ID) {
            return base.Channel.GetSlikaOdgovorByIDpitanjaAsync(ID);
        }
        
        public ConsoleApplication1.ServiceReference1.TekstOdgovor GetTekstOdgovorByIDpitanja(int ID) {
            return base.Channel.GetTekstOdgovorByIDpitanja(ID);
        }
        
        public System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.TekstOdgovor> GetTekstOdgovorByIDpitanjaAsync(int ID) {
            return base.Channel.GetTekstOdgovorByIDpitanjaAsync(ID);
        }
        
        public ConsoleApplication1.ServiceReference1.Pitanje GetPitanjaByIDkategorije(int ID) {
            return base.Channel.GetPitanjaByIDkategorije(ID);
        }
        
        public System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.Pitanje> GetPitanjaByIDkategorijeAsync(int ID) {
            return base.Channel.GetPitanjaByIDkategorijeAsync(ID);
        }
    }
}
