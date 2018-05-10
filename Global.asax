<%@ Application Language="C#" %>
<%@ Import Namespace="System.IO" %>

<script RunAt="server">
    //在应用程序启动时运行的代码
    void Application_Start(object sender, EventArgs e)
    {
        Application["AccessCount"] = 1;
        Application["OnlineCount"] = 1;
        string file = Server.MapPath("AccessCount.txt");
        if (File.Exists(file))
        {
            StreamReader sr = File.OpenText(file);
            Application["AccessCount"] = Int32.Parse(sr.ReadLine());
            sr.Close();
        }
        else
        {
            StreamWriter sw = File.CreateText(file);
            sw.WriteLine("1");
            sw.Close();
        }
    }
    //在应用程序关闭时运行的代码
    void Application_End(object sender, EventArgs e)
    {
        string file = Server.MapPath("AccessCount.txt");
        StreamWriter sw = new StreamWriter(file);
        sw.WriteLine(Application["AccessCount"].ToString());
        sw.Close();
    }
    //在新会话启动时运行的代码
    void Session_Start(object sender, EventArgs e)
    {
        Application.Lock();
        Application["OnlineCount"] = (int)Application["OnlineCount"] + 1;
        Application["AccessCount"] = (int)Application["AccessCount"] + 1;
        Application.UnLock();
    }
    //在会话结束时运行的代码
    void Session_End(object sender, EventArgs e)
    {
        Application.Lock();
        Application["OnlineCount"] = (int)Application["OnlineCount"] - 1;
        Application.UnLock();
    }
</script>

