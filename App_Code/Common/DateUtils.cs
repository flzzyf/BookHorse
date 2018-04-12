using System;
/// ＜summary＞
/// 日期操作工具类
/// ＜/summary＞
public class DateUtils
{
    /// ＜summary＞
    /// 比较日期与当前日期的年份差
    /// ＜/summary＞
    /// ＜param name="start"＞开始日期＜/param＞
    /// ＜returns＞与当前日期的年份差＜/returns＞
    public static int DiffYear(string start)
    {
        return DiffYear(Convert.ToDateTime(start));
    }
    /// ＜summary＞
    /// 比较两个日期之间的年份差
    /// ＜/summary＞
    /// ＜param name="start"＞开始日期＜/param＞
    /// ＜param name="end"＞结束日期＜/param＞
    /// ＜returns＞年份差＜/returns＞
    public static int DiffYear(string start, string end)
    {
        return DiffYear(Convert.ToDateTime(start), Convert.ToDateTime(end));
    }
    /// ＜summary＞
    /// 比较日期与当前日期的年份差
    /// ＜/summary＞
    /// ＜param name="start"＞开始日期＜/param＞
    /// ＜returns＞与当前日期的年份差＜/returns＞
    public static int DiffYear(DateTime start)
    {
        return (DiffYear(start, DateTime.Now));
    }
    /// ＜summary＞
    /// 比较两个日期之间的年份差
    /// ＜/summary＞
    /// ＜param name="start"＞开始日期＜/param＞
    /// ＜param name="end"＞结束日期＜/param＞
    /// ＜returns＞年份差＜/returns＞
    public static int DiffYear(DateTime start, DateTime end)
    {
        return (end.Year - start.Year);
    }
    /// ＜summary＞
    /// 格式化当前日期(yyyy-MM-dd)
    /// ＜/summary＞
    /// ＜returns＞格式化后的日期字符串＜/returns＞
    public static string DateFormat()
    {
        return DateFormat(DateTime.Now);
    }
    /// ＜summary＞
    /// 格式化日期(yyyy-MM-dd)
    /// ＜/summary＞
    /// ＜param name="date"＞待格式化的日期＜/param＞
    /// ＜returns＞格式化后的日期字符串＜/returns＞
    public static string DateFormat(string date)
    {
        return DateFormat(Convert.ToDateTime(date));
    }
    /// ＜summary＞
    /// 格式化日期
    /// ＜/summary＞
    /// ＜param name="date"＞待格式化的日期＜/param＞
    /// ＜param name="format"＞格式化串＜/param＞
    /// ＜returns＞格式化后的日期字符串＜/returns＞
    public static string DateFormat(string date, string format)
    {
        return DateFormat(Convert.ToDateTime(date), format);
    }
    /// ＜summary＞
    /// 格式化日期(yyyy-MM-dd)
    /// ＜/summary＞
    /// ＜param name="date"＞待格式化的日期＜/param＞
    /// ＜returns＞格式化后的日期字符串＜/returns＞
    public static string DateFormat(DateTime date)
    {
        return DateFormat(date, "yyyy-MM-dd");
    }
    /// ＜summary＞
    /// 格式化日期
    /// ＜/summary＞
    /// ＜param name="date"＞待格式化的日期＜/param＞
    /// ＜param name="format"＞格式化串＜/param＞
    /// ＜returns＞格式化后的日期字符串＜/returns＞
    public static string DateFormat(DateTime date, string format)
    {
        return date.ToString(format);
    }
    /// ＜summary＞
    /// 格式化日期时间
    /// ＜/summary＞
    /// ＜param name="datetime"＞待格式化的日期时间＜/param＞
    /// ＜returns＞格式化后的日期时间字符串＜/returns＞
    public static string DateTimeFormat(DateTime datetime)
    {
        return DateTimeFormat(datetime, "yyyy-MM-dd HH:mm");
    }
    /// ＜summary＞
    /// 格式化日期时间
    /// ＜/summary＞
    /// ＜param name="datetime"＞待格式化的日期时间＜/param＞
    /// ＜param name="format"＞格式化串＜/param＞
    /// ＜returns＞格式化后的日期时间字符串＜/returns＞
    public static string DateTimeFormat(DateTime datetime, string format)
    {
        return datetime.ToString(format);
    }
    /// <summary> 
    /// 时间差 
    /// </summary> 
    /// <param name="starttime">开始时间</param> 
    /// <param name="endtime">结束时间</param> 
    /// <returns></returns> 
    public static string GetTimeSpan(DateTime starttime, DateTime endtime)
    {
        TimeSpan ts = endtime - starttime;
        return string.Format("{0}时{1}分{2}秒{3}毫秒", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
    }
}
