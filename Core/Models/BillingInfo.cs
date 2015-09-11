// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2015 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;
using ShareFile.Api.Client.Exceptions;

namespace ShareFile.Api.Models 
{
	public class BillingInfo : ODataObject 
	{

		public User BillingContact { get; set; }

		public string Address1 { get; set; }

		public string Address2 { get; set; }

		public string City { get; set; }

		public string State { get; set; }

		public string Country { get; set; }

		public string Zip { get; set; }

		public string CreditCardFirstName { get; set; }

		public string CreditCardLastName { get; set; }

		public string CreditCardType { get; set; }

		public string CreditCardToken { get; set; }

		public string CreditCardExpirationMonth { get; set; }

		public string CreditCardExpirationYear { get; set; }

		public string CreditCardSecurityCode { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as BillingInfo;
			if(typedSource != null)
			{
				BillingContact = typedSource.BillingContact;
				Address1 = typedSource.Address1;
				Address2 = typedSource.Address2;
				City = typedSource.City;
				State = typedSource.State;
				Country = typedSource.Country;
				Zip = typedSource.Zip;
				CreditCardFirstName = typedSource.CreditCardFirstName;
				CreditCardLastName = typedSource.CreditCardLastName;
				CreditCardType = typedSource.CreditCardType;
				CreditCardToken = typedSource.CreditCardToken;
				CreditCardExpirationMonth = typedSource.CreditCardExpirationMonth;
				CreditCardExpirationYear = typedSource.CreditCardExpirationYear;
				CreditCardSecurityCode = typedSource.CreditCardSecurityCode;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("BillingContact", out token) && token.Type != JTokenType.Null)
				{
					BillingContact = (User)serializer.Deserialize(token.CreateReader(), typeof(User));
				}
				if(source.TryGetProperty("Address1", out token) && token.Type != JTokenType.Null)
				{
					Address1 = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Address2", out token) && token.Type != JTokenType.Null)
				{
					Address2 = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("City", out token) && token.Type != JTokenType.Null)
				{
					City = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("State", out token) && token.Type != JTokenType.Null)
				{
					State = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Country", out token) && token.Type != JTokenType.Null)
				{
					Country = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Zip", out token) && token.Type != JTokenType.Null)
				{
					Zip = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("CreditCardFirstName", out token) && token.Type != JTokenType.Null)
				{
					CreditCardFirstName = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("CreditCardLastName", out token) && token.Type != JTokenType.Null)
				{
					CreditCardLastName = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("CreditCardType", out token) && token.Type != JTokenType.Null)
				{
					CreditCardType = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("CreditCardToken", out token) && token.Type != JTokenType.Null)
				{
					CreditCardToken = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("CreditCardExpirationMonth", out token) && token.Type != JTokenType.Null)
				{
					CreditCardExpirationMonth = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("CreditCardExpirationYear", out token) && token.Type != JTokenType.Null)
				{
					CreditCardExpirationYear = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("CreditCardSecurityCode", out token) && token.Type != JTokenType.Null)
				{
					CreditCardSecurityCode = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
			}
		}
	}
}