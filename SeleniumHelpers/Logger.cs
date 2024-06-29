namespace SeleniumHelpers{
    public class Logger{
        public static void LogInfo(string message){
            string log = $"{DateTime.Now} - {message}";
            TestContext.Out.WriteLine(log);
        }
    }
}