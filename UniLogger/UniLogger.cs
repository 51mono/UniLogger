using System;
using UnityEngine;
using System.Collections.Generic;

namespace LPY.Unity
{
	public class UniLogger
	{
		private static Dictionary<string,UniLogger> logDict=new Dictionary<string, UniLogger>();

		public string Key{ get; set; }

		public static UniLogger GetLogger(string key)
		{
			if (logDict.ContainsKey (key)) {
				return logDict [key];
			} else {
				UniLogger log=new UniLogger();
				log.Key=key;
				logDict.Add(log);
			}
		}

		public void Log(object message)
		{
			Debug.Log (message);
		}
		public void Log(string format,params object[] args)
		{
			Debug.LogFormat(format,args)
		}
	}
}