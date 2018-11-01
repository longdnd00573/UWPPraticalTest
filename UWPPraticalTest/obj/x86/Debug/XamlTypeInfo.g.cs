﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace UWPPraticalTest
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
    private global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlTypeInfoProvider _provider;

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace UWPPraticalTest.UWPPraticalTest_XamlTypeInfo
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[8];
            _typeNameTable[0] = "UWPPraticalTest.MainPage";
            _typeNameTable[1] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[2] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[3] = "System.Collections.ObjectModel.ObservableCollection`1<UWPPraticalTest.POJO.RootObject>";
            _typeNameTable[4] = "System.Collections.ObjectModel.Collection`1<UWPPraticalTest.POJO.RootObject>";
            _typeNameTable[5] = "Object";
            _typeNameTable[6] = "UWPPraticalTest.POJO.RootObject";
            _typeNameTable[7] = "String";

            _typeTable = new global::System.Type[8];
            _typeTable[0] = typeof(global::UWPPraticalTest.MainPage);
            _typeTable[1] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[2] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[3] = typeof(global::System.Collections.ObjectModel.ObservableCollection<global::UWPPraticalTest.POJO.RootObject>);
            _typeTable[4] = typeof(global::System.Collections.ObjectModel.Collection<global::UWPPraticalTest.POJO.RootObject>);
            _typeTable[5] = typeof(global::System.Object);
            _typeTable[6] = typeof(global::UWPPraticalTest.POJO.RootObject);
            _typeTable[7] = typeof(global::System.String);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_MainPage() { return new global::UWPPraticalTest.MainPage(); }
        private object Activate_3_ObservableCollection() { return new global::System.Collections.ObjectModel.ObservableCollection<global::UWPPraticalTest.POJO.RootObject>(); }
        private object Activate_4_Collection() { return new global::System.Collections.ObjectModel.Collection<global::UWPPraticalTest.POJO.RootObject>(); }
        private void VectorAdd_3_ObservableCollection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::UWPPraticalTest.POJO.RootObject>)instance;
            var newItem = (global::UWPPraticalTest.POJO.RootObject)item;
            collection.Add(newItem);
        }
        private void VectorAdd_4_Collection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::UWPPraticalTest.POJO.RootObject>)instance;
            var newItem = (global::UWPPraticalTest.POJO.RootObject)item;
            collection.Add(newItem);
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  UWPPraticalTest.MainPage
                userType = new global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_0_MainPage;
                userType.AddMemberName("collection");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  System.Collections.ObjectModel.ObservableCollection`1<UWPPraticalTest.POJO.RootObject>
                userType = new global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<UWPPraticalTest.POJO.RootObject>"));
                userType.CollectionAdd = VectorAdd_3_ObservableCollection;
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 4:   //  System.Collections.ObjectModel.Collection`1<UWPPraticalTest.POJO.RootObject>
                userType = new global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_4_Collection;
                userType.CollectionAdd = VectorAdd_4_Collection;
                xamlType = userType;
                break;

            case 5:   //  Object
                xamlType = new global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 6:   //  UWPPraticalTest.POJO.RootObject
                userType = new global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.AddMemberName("videoId");
                userType.AddMemberName("name");
                userType.AddMemberName("description");
                userType.AddMemberName("keywords");
                userType.AddMemberName("category");
                userType.AddMemberName("genre");
                userType.AddMemberName("authorName");
                userType.AddMemberName("authorEmail");
                userType.AddMemberName("birthday");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 7:   //  String
                xamlType = new global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;
            }
            return xamlType;
        }


        private object get_0_MainPage_collection(object instance)
        {
            var that = (global::UWPPraticalTest.MainPage)instance;
            return that.collection;
        }
        private void set_0_MainPage_collection(object instance, object Value)
        {
            var that = (global::UWPPraticalTest.MainPage)instance;
            that.collection = (global::System.Collections.ObjectModel.ObservableCollection<global::UWPPraticalTest.POJO.RootObject>)Value;
        }
        private object get_1_RootObject_videoId(object instance)
        {
            var that = (global::UWPPraticalTest.POJO.RootObject)instance;
            return that.videoId;
        }
        private void set_1_RootObject_videoId(object instance, object Value)
        {
            var that = (global::UWPPraticalTest.POJO.RootObject)instance;
            that.videoId = (global::System.String)Value;
        }
        private object get_2_RootObject_name(object instance)
        {
            var that = (global::UWPPraticalTest.POJO.RootObject)instance;
            return that.name;
        }
        private void set_2_RootObject_name(object instance, object Value)
        {
            var that = (global::UWPPraticalTest.POJO.RootObject)instance;
            that.name = (global::System.String)Value;
        }
        private object get_3_RootObject_description(object instance)
        {
            var that = (global::UWPPraticalTest.POJO.RootObject)instance;
            return that.description;
        }
        private void set_3_RootObject_description(object instance, object Value)
        {
            var that = (global::UWPPraticalTest.POJO.RootObject)instance;
            that.description = (global::System.String)Value;
        }
        private object get_4_RootObject_keywords(object instance)
        {
            var that = (global::UWPPraticalTest.POJO.RootObject)instance;
            return that.keywords;
        }
        private void set_4_RootObject_keywords(object instance, object Value)
        {
            var that = (global::UWPPraticalTest.POJO.RootObject)instance;
            that.keywords = (global::System.String)Value;
        }
        private object get_5_RootObject_category(object instance)
        {
            var that = (global::UWPPraticalTest.POJO.RootObject)instance;
            return that.category;
        }
        private void set_5_RootObject_category(object instance, object Value)
        {
            var that = (global::UWPPraticalTest.POJO.RootObject)instance;
            that.category = (global::System.String)Value;
        }
        private object get_6_RootObject_genre(object instance)
        {
            var that = (global::UWPPraticalTest.POJO.RootObject)instance;
            return that.genre;
        }
        private void set_6_RootObject_genre(object instance, object Value)
        {
            var that = (global::UWPPraticalTest.POJO.RootObject)instance;
            that.genre = (global::System.String)Value;
        }
        private object get_7_RootObject_authorName(object instance)
        {
            var that = (global::UWPPraticalTest.POJO.RootObject)instance;
            return that.authorName;
        }
        private void set_7_RootObject_authorName(object instance, object Value)
        {
            var that = (global::UWPPraticalTest.POJO.RootObject)instance;
            that.authorName = (global::System.String)Value;
        }
        private object get_8_RootObject_authorEmail(object instance)
        {
            var that = (global::UWPPraticalTest.POJO.RootObject)instance;
            return that.authorEmail;
        }
        private void set_8_RootObject_authorEmail(object instance, object Value)
        {
            var that = (global::UWPPraticalTest.POJO.RootObject)instance;
            that.authorEmail = (global::System.String)Value;
        }
        private object get_9_RootObject_birthday(object instance)
        {
            var that = (global::UWPPraticalTest.POJO.RootObject)instance;
            return that.birthday;
        }
        private void set_9_RootObject_birthday(object instance, object Value)
        {
            var that = (global::UWPPraticalTest.POJO.RootObject)instance;
            that.birthday = (global::System.String)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlMember xamlMember = null;
            global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "UWPPraticalTest.MainPage.collection":
                userType = (global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPraticalTest.MainPage");
                xamlMember = new global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlMember(this, "collection", "System.Collections.ObjectModel.ObservableCollection`1<UWPPraticalTest.POJO.RootObject>");
                xamlMember.Getter = get_0_MainPage_collection;
                xamlMember.Setter = set_0_MainPage_collection;
                break;
            case "UWPPraticalTest.POJO.RootObject.videoId":
                userType = (global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPraticalTest.POJO.RootObject");
                xamlMember = new global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlMember(this, "videoId", "String");
                xamlMember.Getter = get_1_RootObject_videoId;
                xamlMember.Setter = set_1_RootObject_videoId;
                break;
            case "UWPPraticalTest.POJO.RootObject.name":
                userType = (global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPraticalTest.POJO.RootObject");
                xamlMember = new global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlMember(this, "name", "String");
                xamlMember.Getter = get_2_RootObject_name;
                xamlMember.Setter = set_2_RootObject_name;
                break;
            case "UWPPraticalTest.POJO.RootObject.description":
                userType = (global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPraticalTest.POJO.RootObject");
                xamlMember = new global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlMember(this, "description", "String");
                xamlMember.Getter = get_3_RootObject_description;
                xamlMember.Setter = set_3_RootObject_description;
                break;
            case "UWPPraticalTest.POJO.RootObject.keywords":
                userType = (global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPraticalTest.POJO.RootObject");
                xamlMember = new global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlMember(this, "keywords", "String");
                xamlMember.Getter = get_4_RootObject_keywords;
                xamlMember.Setter = set_4_RootObject_keywords;
                break;
            case "UWPPraticalTest.POJO.RootObject.category":
                userType = (global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPraticalTest.POJO.RootObject");
                xamlMember = new global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlMember(this, "category", "String");
                xamlMember.Getter = get_5_RootObject_category;
                xamlMember.Setter = set_5_RootObject_category;
                break;
            case "UWPPraticalTest.POJO.RootObject.genre":
                userType = (global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPraticalTest.POJO.RootObject");
                xamlMember = new global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlMember(this, "genre", "String");
                xamlMember.Getter = get_6_RootObject_genre;
                xamlMember.Setter = set_6_RootObject_genre;
                break;
            case "UWPPraticalTest.POJO.RootObject.authorName":
                userType = (global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPraticalTest.POJO.RootObject");
                xamlMember = new global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlMember(this, "authorName", "String");
                xamlMember.Getter = get_7_RootObject_authorName;
                xamlMember.Setter = set_7_RootObject_authorName;
                break;
            case "UWPPraticalTest.POJO.RootObject.authorEmail":
                userType = (global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPraticalTest.POJO.RootObject");
                xamlMember = new global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlMember(this, "authorEmail", "String");
                xamlMember.Getter = get_8_RootObject_authorEmail;
                xamlMember.Setter = set_8_RootObject_authorEmail;
                break;
            case "UWPPraticalTest.POJO.RootObject.birthday":
                userType = (global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPraticalTest.POJO.RootObject");
                xamlMember = new global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlMember(this, "birthday", "String");
                xamlMember.Getter = get_9_RootObject_birthday;
                xamlMember.Setter = set_9_RootObject_birthday;
                break;
            }
            return xamlMember;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlSystemBaseType
    {
        global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::UWPPraticalTest.UWPPraticalTest_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}

