using System;
using System.Collections.Generic;

namespace com.adjust.sdk
{
	public interface IAdjust
	{
	 	void appDidLaunch (string appToken, Util.Environment environment, Util.LogLevel logLevel, bool eventBuffering);
		void trackEvent (string eventToken, Dictionary<string,string> parameters = null);
		void trackRevenue (double cents, string eventToken = null, Dictionary<string,string> parameters = null);
		void onPause ();
		void onResume();
		void setResponseDelegate(string sceneName);
	}
}