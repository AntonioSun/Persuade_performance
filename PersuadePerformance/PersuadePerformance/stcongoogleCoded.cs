﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersuadePerformance {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.WebTesting;
    using Microsoft.VisualStudio.TestTools.WebTesting.Rules;
    
    
    [Priority(0)]
    public class stcongoogleCoded : WebTest {
        
        public stcongoogleCoded() {
            this.PreAuthenticate = true;
        }
        
        public override IEnumerator<WebTestRequest> GetRequestEnumerator() {
            WebTestRequest request1 = new WebTestRequest("https://staging.brightwhistle.com/");
            request1.Timeout = 60;
            request1.ParseDependentRequests = false;
            request1.Headers.Add(new WebTestRequestHeader("Upgrade-Insecure-Requests", "1"));
            request1.Headers.Add(new WebTestRequestHeader("If-None-Match", "\"202ef1e9e7b2d8cac9844e5b71e49b54\""));
            ExtractHiddenFields extractionRule1 = new ExtractHiddenFields();
            extractionRule1.Required = true;
            extractionRule1.HtmlDecode = true;
            extractionRule1.ContextParameterName = "1";
            request1.ExtractValues += new EventHandler<ExtractionEventArgs>(extractionRule1.Extract);
            yield return request1;
            request1 = null;

            WebTestRequest request2 = new WebTestRequest("https://staging.brightwhistle.com/sign_in");
            request2.ThinkTime = 1;
            request2.Timeout = 60;
            request2.Method = "POST";
            request2.Headers.Add(new WebTestRequestHeader("Origin", "https://staging.brightwhistle.com"));
            request2.Headers.Add(new WebTestRequestHeader("Upgrade-Insecure-Requests", "1"));
            request2.Headers.Add(new WebTestRequestHeader("Content-Type", "application/x-www-form-urlencoded"));
            FormPostHttpBody request2Body = new FormPostHttpBody();
            request2Body.FormPostParameters.Add("utf8", "✓");
            request2Body.FormPostParameters.Add("authenticity_token", this.Context["$HIDDEN1.authenticity_token"].ToString());
            request2Body.FormPostParameters.Add("window_resolution", "1349x663");
            request2Body.FormPostParameters.Add("user[email]", "madhuri.m-ext@influencehealth.com");
            request2Body.FormPostParameters.Add("user[password]", "Meds123!@");
            request2Body.FormPostParameters.Add("commit", "Sign in");
            request2.Body = request2Body;
            ExtractAttributeValue extractionRule2 = new ExtractAttributeValue();
            extractionRule2.TagName = "meta";
            extractionRule2.AttributeName = "content";
            extractionRule2.MatchAttributeName = "name";
            extractionRule2.MatchAttributeValue = "csrf-token";
            extractionRule2.HtmlDecode = true;
            extractionRule2.Required = true;
            extractionRule2.Index = 0;
            extractionRule2.ContextParameterName = "authToken";
            request2.ExtractValues += new EventHandler<ExtractionEventArgs>(extractionRule2.Extract);
            yield return request2;
            request2 = null;

            // Context
            this.AddCommentToResult("Context");

            WebTestRequest request3 = new WebTestRequest("https://staging.brightwhistle.com/context.html");
            request3.ThinkTime = 4;
            request3.Timeout = 60;
            request3.Method = "PUT";
            request3.Headers.Add(new WebTestRequestHeader("Origin", "https://staging.brightwhistle.com"));
            request3.Headers.Add(new WebTestRequestHeader("X-CSRF-Token", this.Context["authToken"].ToString()));
            request3.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3.QueryStringParameters.Add("context[agency_id]", "1");
            request3.QueryStringParameters.Add("context[client_id]", "3");
            FormPostHttpBody request3Body = new FormPostHttpBody();
            request3.Body = request3Body;
            yield return request3;
            request3 = null;

            WebTestRequest request4 = new WebTestRequest("https://staging.brightwhistle.com/dashboard");
            request4.Timeout = 60;
            request4.Headers.Add(new WebTestRequestHeader("Upgrade-Insecure-Requests", "1"));
            request4.Headers.Add(new WebTestRequestHeader("If-None-Match", "\"8422cf8dbfb0360b92e7e047ed8382e1\""));
            yield return request4;
            request4 = null;
        }
    }
}
