namespace SeleniumHelpers{
    public class Logger{
        // private static TestContext? testContextInstance;
        // public static TestContext? TestContext{
        //     get{
        //         return testContextInstance;
        //     }
        //     set{
        //         testContextInstance =value;
        //     }
        // }
        public static void LogInfo(string message){
            string log = $"{DateTime.Now} - {message}";
            TestContext.Out.WriteLine(log);
        }
    }
}