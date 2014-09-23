using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Reflection;
using System.IO;
using System.Collections.Specialized;

namespace FincadMonitor.Fincad
{

	public class F3Formatter : IFormatter
	{
		private SerializationBinder m_binder;
		private StreamingContext m_context;

		private ISurrogateSelector m_surrogateSelector;
		public F3Formatter()
		{
			m_context = new StreamingContext(StreamingContextStates.All);
		}

		public object Deserialize(System.IO.Stream serializationStream)
		{
			StreamReader sr = new StreamReader(serializationStream);

			// Get Type from serialized data.
			string line = sr.ReadLine();
			char[] delim = new char[] { '=' };
			string[] sarr = line.Split(delim);
			string className = sarr[1];
			Type t = Type.GetType(className);

			// Create object of just found type name.
			Object obj = FormatterServices.GetUninitializedObject(t);


			// TODO: Use GetBetween Populate object values and return object.

			return null;
			//FormatterServices.PopulateObjectMembers(obj, members, data);
		}

		/// <summary>
		/// F3 Function Call string builder
		/// </summary>
		/// <param name="function_name"></param>
		/// <param name="obj"></param>
		/// <returns></returns>
		public static string f3_style_serialization(string function_name, object obj)
		{

			string call_string = "";
			F3Formatter f = new F3Formatter();
			byte[] buffer = new byte[10000];


			// 
			// constructing f3 style xml function call string
			// 


			using (var f3_call_str = new MemoryStream(buffer)) {
				f.Serialize2(f3_call_str, function_name, obj);
				if (f3_call_str.CanRead) {
					System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
					call_string = enc.GetString(buffer, 0, Convert.ToInt32(f3_call_str.Position));
				}
				f3_call_str.Close();
			}
			return call_string;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="serializationStream"></param>
		/// <param name="f3obj"></param>
		public void Serialize(System.IO.Stream serializationStream, object f3obj)
		{
		}

		/// <summary>
		/// F3 Object Serialzation (Function call string builder)
		/// </summary>
		/// <param name="serializationStream"></param>
		/// <param name="function_name"></param>
		/// <param name="f3obj"></param>
		/// 
		public void Serialize2(System.IO.Stream serializationStream, string function_name, object f3obj)
		{
			// Get fields data.
			PropertyInfo[] properties = f3obj.GetType().GetProperties();
			StreamWriter sw = new StreamWriter(serializationStream);
			//TODO: write the <f><n>
			sw.Write(String.Format("<f><n>{0}</n><a>", function_name));


			if (object.ReferenceEquals(f3obj.GetType(), typeof(Hashtable))) {
				Hashtable m_hashtable = new Hashtable();
				m_hashtable = (Hashtable)f3obj;
				foreach (string name in m_hashtable.Keys) {
					Console.WriteLine(name + "\t" + Convert.ToString(m_hashtable[name]));
					if (m_hashtable[name] == null) {
						string temp = String.Format("<p><n>{0}</n><v><r><m/></r></v></p>", name);
						sw.Write(temp);
					} else if (object.ReferenceEquals(m_hashtable[name].GetType(), typeof(string))) {
						string temp = String.Format("<p><n>{0}</n><v><r><s>{1}</s></r></v></p>", name, m_hashtable[name]);
						sw.Write(temp);
					} else if (object.ReferenceEquals(m_hashtable[name].GetType(), typeof(double))) {
						string temp = String.Format("<p><n>{0}</n><v><r><d>{1}</d></r></v></p>", name, m_hashtable[name]);
						sw.Write(temp);
					} else if (object.ReferenceEquals(m_hashtable[name].GetType(), typeof(bool))) {
						string temp = String.Format("<p><n>{0}</n><v><r><b>{1}</b></r></v></p>", name, m_hashtable[name]);
						sw.Write(temp);
					} else if (object.ReferenceEquals(m_hashtable[name].GetType(), typeof(int))) {
						string temp = String.Format("<p><n>{0}</n><v><r><e>{1}</e></r></v></p>", name, m_hashtable[name]);
						sw.Write(temp);
					} else if (object.ReferenceEquals(m_hashtable[name].GetType(), typeof(DateTime))) {
						string temp = String.Format("<p><n>{0}</n><v><r><D>{1}</D></r></v></p>", name, m_hashtable[name]);
						sw.Write(temp);
					} else if (object.ReferenceEquals(m_hashtable[name].GetType(), typeof(List<List<object>>))) {
						string temp = String.Format("<p><n>{0}</n><v>", name);
						sw.Write(temp);

						object objValue = m_hashtable[name];

						List<List<object>> ObjList = objValue as List<List<object>>;
						string temp2 = String.Format("<p><m/><v>");

						foreach (object node in ObjList) {
							if (node == null) {
								temp2 = String.Format("<r><m/></r>");
							} else if (object.ReferenceEquals(node.GetType(), typeof(string))) {
								temp2 = String.Format("<r><s>{0}</s></r>", node);
							} else if (object.ReferenceEquals(node.GetType(), typeof(double))) {
								temp2 = String.Format("<r><d>{0}</d></r>", node);
							} else if (object.ReferenceEquals(node.GetType(), typeof(bool))) {
								temp2 = String.Format("<r><b>{0}</b></r>", node);
							} else if (object.ReferenceEquals(node.GetType(), typeof(int))) {
								temp2 = String.Format("<r><e>{0}</e></r>", node);
							} else if (object.ReferenceEquals(node.GetType(), typeof(DateTime))) {
								temp2 = String.Format("<r><D>{0}</D></r>", node);
							} else if (object.ReferenceEquals(node.GetType(), typeof(List<object>))) {
								sw.Write("<r>");
								List<object> ObjList1 = node as List<object>;
								foreach (object node1 in ObjList1) {
									if (node == null) {
										temp2 = String.Format("<r><m/></r>");
									} else if (object.ReferenceEquals(node1.GetType(), typeof(string))) {
										temp2 = String.Format("<s>{0}</s>", node1);
									} else if (object.ReferenceEquals(node1.GetType(), typeof(double))) {
										temp2 = String.Format("<d>{0}</d>", node1);
									} else if (object.ReferenceEquals(node1.GetType(), typeof(bool))) {
										temp2 = String.Format("<b>{0}</b>", node1);
									} else if (object.ReferenceEquals(node1.GetType(), typeof(int))) {
										temp2 = String.Format("<e>{0}</e>", node1);
									} else if (object.ReferenceEquals(node1.GetType(), typeof(DateTime))) {
										temp2 = String.Format("<D>{0}</D>", node1);
									}
									sw.Write(temp2);
								}
								sw.Write("</r>");
							}
						}
						sw.Write("</v></p>");
					} else if (object.ReferenceEquals(m_hashtable[name].GetType(), typeof(List<object>))) {
						string temp = String.Format("<p><n>{0}</n><v><r>", name);
						sw.Write(temp);
						object objValue = m_hashtable[name];
						List<object> ObjList = objValue as List<object>;
						string temp2 = String.Format("<p><m/><v>");
						foreach (object node in ObjList) {
							if (node == null) {
								temp2 = String.Format("<r><m/></r>");
							} else if (object.ReferenceEquals(node.GetType(), typeof(string))) {
								temp2 = String.Format("<s>{0}</s>", node);
							} else if (object.ReferenceEquals(node.GetType(), typeof(double))) {
								temp2 = String.Format("<d>{0}</d>", node);
							} else if (object.ReferenceEquals(node.GetType(), typeof(bool))) {
								temp2 = String.Format("<b>{0}</b>", node);
							} else if (object.ReferenceEquals(node.GetType(), typeof(int))) {
								temp2 = String.Format("<e>{0}</e>", node);
							} else if (object.ReferenceEquals(node.GetType(), typeof(DateTime))) {
								temp2 = String.Format("<D>{0}</D>", node);
							}
							sw.Write(temp2);
						}
						sw.Write("</r></v></p>");
					} else {
						string temp = String.Format("<p><n>{0}</n><v><r><m/></r></v></p>", name);
						sw.Write(temp);
					}
				}
			}

			sw.WriteLine("</a></f>");
			sw.Flush();
		}

		public ISurrogateSelector SurrogateSelector {
			get { return m_surrogateSelector; }
			set { m_surrogateSelector = value; }
		}
		public SerializationBinder Binder {
			get { return m_binder; }
			set { m_binder = value; }
		}
		public StreamingContext Context {
			get { return m_context; }
			set { m_context = value; }
		}
	}

}