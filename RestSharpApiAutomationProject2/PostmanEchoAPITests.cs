

namespace RestSharpApiAutomationProject2
{
    public class Tests
    {
        PostmanEchoPage echoPage;

        public Tests()
        {
            echoPage = new PostmanEchoPage();
        }

        [Test,Order(1)]
        public void AddDate()
        {
            echoPage.DateSumRequest();
        }

        [Test,Order(2)]
        public void SubDate()
        {
            echoPage.DateSubRequest();
        }

    }
}