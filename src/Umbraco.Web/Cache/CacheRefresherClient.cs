﻿using Umbraco.Core.IO;

namespace Umbraco.Web.Cache
{
    
    /// <summary>
    /// The client Soap service for making distrubuted cache calls between servers
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "CacheRefresherSoap", Namespace = "http://umbraco.org/webservices/")]
    internal class CacheRefresherClient : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        /// <remarks/>
        public CacheRefresherClient()
        {
            // only set the url if the httpcontext is present, else it's set by the cache dispatcher methods (when using distributed calls)
            if (System.Web.HttpContext.Current != null)
                this.Url = "http://" + System.Web.HttpContext.Current.Request.ServerVariables["SERVER_NAME"] + IOHelper.ResolveUrl(SystemDirectories.WebServices) + "/cacheRefresher.asmx";

        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://umbraco.org/webservices/RefreshAll", RequestNamespace = "http://umbraco.org/webservices/", ResponseNamespace = "http://umbraco.org/webservices/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void RefreshAll(System.Guid uniqueIdentifier, string Login, string Password)
        {
            this.Invoke("RefreshAll", new object[] {
													   uniqueIdentifier,
													   Login,
													   Password});
        }

        /// <remarks/>
        public System.IAsyncResult BeginRefreshAll(System.Guid uniqueIdentifier, string Login, string Password, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("RefreshAll", new object[] {
																   uniqueIdentifier,
																   Login,
																   Password}, callback, asyncState);
        }

        /// <remarks/>
        public void EndRefreshAll(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://umbraco.org/webservices/RefreshByGuid", RequestNamespace = "http://umbraco.org/webservices/", ResponseNamespace = "http://umbraco.org/webservices/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void RefreshByGuid(System.Guid uniqueIdentifier, System.Guid Id, string Login, string Password)
        {
            this.Invoke("RefreshByGuid", new object[] {
														  uniqueIdentifier,
														  Id,
														  Login,
														  Password});
        }

        /// <remarks/>
        public System.IAsyncResult BeginRefreshByGuid(System.Guid uniqueIdentifier, System.Guid Id, string Login, string Password, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("RefreshByGuid", new object[] {
																	  uniqueIdentifier,
																	  Id,
																	  Login,
																	  Password}, callback, asyncState);
        }

        /// <remarks/>
        public void EndRefreshByGuid(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://umbraco.org/webservices/RefreshById", RequestNamespace = "http://umbraco.org/webservices/", ResponseNamespace = "http://umbraco.org/webservices/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void RefreshById(System.Guid uniqueIdentifier, int Id, string Login, string Password)
        {
            this.Invoke("RefreshById", new object[] {
														uniqueIdentifier,
														Id,
														Login,
														Password});
        }

        /// <remarks/>
        public System.IAsyncResult BeginRefreshById(System.Guid uniqueIdentifier, int Id, string Login, string Password, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("RefreshById", new object[] {
																	uniqueIdentifier,
																	Id,
																	Login,
																	Password}, callback, asyncState);
        }

        /// <remarks/>
        public void EndRefreshById(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://umbraco.org/webservices/RemoveById", RequestNamespace = "http://umbraco.org/webservices/", ResponseNamespace = "http://umbraco.org/webservices/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void RemoveById(System.Guid uniqueIdentifier, int Id, string Login, string Password)
        {
            this.Invoke("RemoveById", new object[] {
														uniqueIdentifier,
														Id,
														Login,
														Password});
        }

        /// <remarks/>
        public System.IAsyncResult BeginRemoveById(System.Guid uniqueIdentifier, int Id, string Login, string Password, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("RemoveById", new object[] {
																	uniqueIdentifier,
																	Id,
																	Login,
																	Password}, callback, asyncState);
        }

        /// <remarks/>
        public void EndRemoveById(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://umbraco.org/webservices/GetRefreshers", RequestNamespace = "http://umbraco.org/webservices/", ResponseNamespace = "http://umbraco.org/webservices/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Xml.XmlNode GetRefreshers(string Login, string Password)
        {
            object[] results = this.Invoke("GetRefreshers", new object[] {
																			 Login,
																			 Password});
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetRefreshers(string Login, string Password, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetRefreshers", new object[] {
																	  Login,
																	  Password}, callback, asyncState);
        }

        /// <remarks/>
        public System.Xml.XmlNode EndGetRefreshers(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Xml.XmlNode)(results[0]));
        }
    }
}