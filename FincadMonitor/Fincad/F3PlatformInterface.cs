using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Net;
using System.IO;
using System.Web;

namespace FincadMonitor.Fincad
{
	public class F3PlatformInterface
	{
		private static F3PlatformInterface objSingle;
		private static bool blCreated;

		public string strI;

		private string _g_uri;
		// property g_uri
		public string g_uri {
			get { return _g_uri.ToString(); }
			set { _g_uri = value; }
		}
		// g_uri

		private F3PlatformInterface(ref string uri)
		{
			//Override the default constructor
			_g_uri = uri;
		}

		public static F3PlatformInterface getInstance(ref string uri)
		{
			if (blCreated == false) {
				objSingle = new F3PlatformInterface(ref uri);
				blCreated = true;
				return objSingle;
			} else {
                objSingle.g_uri = uri;
				return objSingle;
			}
		}

		public string HttpGet(ref string api, string method)
		{
			WebRequest req = WebRequest.Create(g_uri + api);
			//req.Proxy = New WebProxy("localproxyIP:8505", True) 'true means no proxy
			req.Method = method;
			HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
			Console.WriteLine(resp.StatusDescription);
			Stream dataStream = resp.GetResponseStream();
			// Open the stream using a StreamReader for easy access. 
			StreamReader reader = new StreamReader(dataStream);
			// Read the content. 
			string responseFromServer = reader.ReadToEnd().Trim();
			reader.Close();
			dataStream.Close();
			resp.Close();
			return responseFromServer;
		}

		public string f3PlatRPC(ref string api, ref string method, string data = "", string ContentType = "application/x-www-form-urlencoded", string Accept = "application/x-www-form-urlencoded")
		{
			string responseFromServer = "";
			try {
				if ((method != "POST")) {
					return HttpGet(ref api, method);
				} else {
					HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(g_uri + api);
					httpWebRequest.ContentType = ContentType;
					httpWebRequest.Accept = Accept;
					httpWebRequest.Method = method;
					httpWebRequest.ContentLength = data.Length;

					byte[] postByteArray = Encoding.UTF8.GetBytes(data);
					System.IO.Stream postStream = httpWebRequest.GetRequestStream();
					postStream.Write(postByteArray, 0, postByteArray.Length);
					postStream.Close();

					HttpWebResponse resp = (HttpWebResponse)httpWebRequest.GetResponse();
					Console.WriteLine(resp.StatusDescription);
					Stream dataStream = resp.GetResponseStream();
					// Open the stream using a StreamReader for easy access. 
					StreamReader reader = new StreamReader(dataStream);
					// Read the content. 
					responseFromServer = reader.ReadToEnd().Trim();
					reader.Close();
					dataStream.Close();
					resp.Close();
				}
			} catch (Exception e) {
				responseFromServer = "An error occurred: " + e.Message;
			}
			return responseFromServer;
		}

		public string SendRESTRequest(string api, byte[] jsonDataBytes, string contentType, string method)
		{
			string responseFromServer = "";
			try {
				WebRequest req = WebRequest.Create(g_uri + api);
				req.ContentType = contentType;
				req.Method = method;
				req.ContentLength = jsonDataBytes.Length;
				dynamic stream = req.GetRequestStream();
				stream.Write(jsonDataBytes, 0, jsonDataBytes.Length);
				stream.Close();

				dynamic response = req.GetResponse().GetResponseStream();

				StreamReader reader = new StreamReader(response);
				responseFromServer = reader.ReadToEnd();
				reader.Close();
				response.Close();
			} catch (Exception e) {
				responseFromServer = "An error occurred: " + e.Message;
			}
			return responseFromServer;
		}

		public string executef3ml(ref string callstring, ref string session_id)
		{
            string functionName = "executef3ml";
            string methodName = "POST";

			string responseFromServer = "";
			try {
				string encodedStr = null;
				encodedStr = HttpUtility.UrlEncode(callstring).Trim();
				string data = "f3ml=" + encodedStr + "&session=" + session_id;
                responseFromServer = f3PlatRPC(ref functionName, ref methodName, data, "application/x-www-form-urlencoded", "application/x-www-form-urlencoded");
			} catch (Exception e) {
				responseFromServer = "An error occurred: " + e.Message;
			}
			return responseFromServer;
		}

		public string ExportModel(string file_name, string session_id = "")
		{

			try {
				// create an instance of F3 manager object with the license and version infomation

                string functionName = "executef3ml";
                string methodName = "POST";

				string output_str = "";
				string sessionID = session_id;
				string callstring = "";
				string encodedStr = "";
				string data = "";
				F3XMLFunctionsBuilder fc = new F3XMLFunctionsBuilder();

				//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
				//assuming that F3 Platform have access to the given "file_name"
				//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

				callstring = fc.ImportObjects(file_name, null).ToString();
				encodedStr = HttpUtility.UrlEncode(callstring).Trim();
				data = "f3ml=" + encodedStr + "&session=" + session_id;
				// call f3 engine for each line to build the instrument
                string result = f3PlatRPC(ref functionName, ref methodName, data, "application/x-www-form-urlencoded", "application/x-www-form-urlencoded");                
				output_str = result;
				return output_str;
			} catch (System.Exception ex) {
				string exception_str = ex.GetType().ToString() + " from " + ex.Source + " object. " + ex.Message;
				return (exception_str);
			}
		}

		public string GetSessionID()
		{
            string functionName = "startsession";
            string methodName = "POST";

			try {
				string output_str = "";
				// call f3 engine for each line to build the instrument
				//string result = f3PlatRPC("startsession", "POST");
                string result = f3PlatRPC(ref functionName, ref methodName, "", "application/x-www-form-urlencoded", "application/x-www-form-urlencoded");                
				output_str = result;
				return output_str;
			} catch (System.Exception ex) {
				string exception_str = ex.GetType().ToString() + " from " + ex.Source + " object. " + ex.Message;
				return (exception_str);
			}
		}

		public string DeleteSessionID(string session_id)
		{

            string functionName = "endsession";
            string methodName = "POST";

			try {
				// create an instance of F3 manager object with the license and version infomation

				
				string data = "";
				string output_str = "";

				data = "id=" + session_id;
				// call f3 engine for each line to build the instrument
                string result = f3PlatRPC(ref functionName, ref methodName, data, "application/x-www-form-urlencoded", "application/x-www-form-urlencoded");               				
				output_str = result;
				return output_str;
			} catch (System.Exception ex) {
				string exception_str = ex.GetType().ToString() + " from " + ex.Source + " object. " + ex.Message;
				return (exception_str);
			}
		}

		public string GetStatus()
		{
            string functionName = "status";
            string methodName = "GET";

			try {
				string output_str = "";
				// call f3 engine for each line to build the instrument
                string result = f3PlatRPC(ref functionName, ref methodName, "", "application/x-www-form-urlencoded", "application/x-www-form-urlencoded");               				
				output_str = result;
				return output_str;
			} catch (System.Exception ex) {
				string exception_str = ex.GetType().ToString() + " from " + ex.Source + " object. " + ex.Message;
				return (exception_str);
			}
		}

		public string ListSessions()
		{

            string functionName = "listsessions";
            string methodName = "GET";

			try {
				string output_str = "";
				// call f3 engine for each line to build the instrument
                string result = f3PlatRPC(ref functionName, ref methodName, "", "application/x-www-form-urlencoded", "application/x-www-form-urlencoded");               				
				output_str = result;
				return output_str;
			} catch (System.Exception ex) {
				string exception_str = ex.GetType().ToString() + " from " + ex.Source + " object. " + ex.Message;
				return (exception_str);
			}
		}

	}
}