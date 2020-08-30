using NLog;

namespace Purgomalum.Service
{
    public class PurgomalumContainsAPI
    {
        private string _purgomalResponse;
        private readonly Logger _log;
        private readonly PurgomalumAPI _purgomalumAPI;

        public PurgomalumContainsAPI(Logger log, PurgomalumAPI purgomalumAPI)
        {
            _log = log;

            _purgomalumAPI = purgomalumAPI;
        }

        public void ProcessText(string text)
        {
            _log.Trace("Checking if text contains profanity");

            _purgomalumAPI.SetTextToBeProcessed(text);

            _purgomalResponse = _purgomalumAPI.ExecuteReturnContent();
        }

        public bool GetContainsBool()
        {
            bool.TryParse(_purgomalResponse, out bool parsedValue);

            return parsedValue;
        }
    }
}