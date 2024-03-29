﻿using System;


public class HelpAttribute : System.Attribute
{
    public HelpAttribute(string url)
    {
        Url = url;
    }

    public string Url { get; }

    public string Topic
    {
        get;
        set;
    }
}

[Help("https://docs.microsoft.com/dotnet/csharp/tour-of-csharp/attributes")]
public class Widget
{
    [Help("https://docs.microsoft.com/dotnet/csharp/tour-of-csharp/attributes",
    Topic = "Display")]
    public void Display(string text) { }
}


class Program
{
    static void Main(string[] args)
    {
        Type widgetType = typeof(Widget);
        //Gets every HelpAttribute defined for the Widget type
        object[] widgetClassAttributes = widgetType.GetCustomAttributes(typeof(HelpAttribute), false);

        if (widgetClassAttributes.Length > 0)
        {
            HelpAttribute attr = (HelpAttribute)widgetClassAttributes[0];
            Console.WriteLine($"Widget class help URL : {attr.Url} - Related topic : {attr.Topic}");
        }




        System.Reflection.MethodInfo displayMethod = widgetType.GetMethod(nameof(Widget.Display));
        //Gets every HelpAttribute defined for the Widget.Display method
        object[] displayMethodAttributes = displayMethod.GetCustomAttributes(typeof(HelpAttribute), false);

        if (displayMethodAttributes.Length > 0)
        {
            HelpAttribute attr = (HelpAttribute)displayMethodAttributes[0];
            Console.WriteLine($"Display method help URL : {attr.Url} - Related topic : {attr.Topic}");
        }

        Console.ReadLine();
    }
}





