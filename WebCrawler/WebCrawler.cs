using System;
using System.Collections.ObjectModel;

namespace WebCrawler
{
    public class WebCrawler
    {




    }


    public class AttackEngine
    {
        private Collection<AttackResult> attackResults;
        private Collection<IAttackResultCollector> attackResultCollectors;

        public AttackEngine()
        {


        }




    }


    public struct AttackResult
    {
        public string url;
        public RequestType requestType;
        public AttackType attackType;
        public bool result;
    }


    public enum AttackType
    { 
        xss,
        xsrf,
    }

    public enum RequestType
    {
        get,
        post,
    }

    public interface IAttackResult
    {


    }

    public interface IAttackResultCollector
    {

    }

}
