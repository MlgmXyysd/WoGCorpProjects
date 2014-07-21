﻿namespace Mygod.WorldOfGoo
{
    /// <summary>
    /// 无需本地化的数据，节省最终程序集大小、避免常量过期而使用。
    /// </summary>
    static class R
    {
        // ReSharper disable ConvertToConstant.Global
        public static readonly string
            ProfilePath = @"2DBoy\WorldOfGoo\pers2.dat",
            GooBallTesterLevelName = "WogmGooBallTester",
            GooBallTestHelperGooBallName = "WogmGooBallTestHelper",
            MaterialTesterLevelName = "WogmMaterialTester",
            True = "true", ProfileDefaultContent = "10,fullscreen4,true,0.", 
            False = "false",
            BackupExtension = ".wogmpbak",
            TechSupportUrl = "http://mygod.apphb.com/#Product-54", 
            HelpExtension = "htm",
            ModifiedXml = "Modified.xml", ID = "ID", ModifiedTimes = "ModifiedTimes", Feature = "Feature", Modified = "Modified",
            ConsoleOutput = "output.txt",
            ThemeDirectory = "Resources/Themes",
            Xaml = ".xaml", Baml = ".baml", 
            ThemeWatcherFilter = '*' + Xaml + ";*" + Baml,
            Zero = "0", Balls = "balls", Resources = "resources", Level = "level", Scene = "scene", Resrc = "resrc", GooBalls = "GooBalls";

        // ReSharper restore ConvertToConstant.Global
    }
}