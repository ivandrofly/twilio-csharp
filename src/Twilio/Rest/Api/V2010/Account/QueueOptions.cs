using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Api.V2010.Account 
{

    /// <summary>
    /// Fetch an instance of a queue identified by the QueueSid
    /// </summary>
    public class FetchQueueOptions : IOptions<QueueResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Fetch by unique queue Sid
        /// </summary>
        public string PathSid { get; }
    
        /// <summary>
        /// Construct a new FetchQueueOptions
        /// </summary>
        ///
        /// <param name="pathSid"> Fetch by unique queue Sid </param>
        public FetchQueueOptions(string pathSid)
        {
            PathSid = pathSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// Update the queue with the new parameters
    /// </summary>
    public class UpdateQueueOptions : IOptions<QueueResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A human readable description of the queue
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The max number of members allowed in the queue
        /// </summary>
        public int? MaxSize { get; set; }
    
        /// <summary>
        /// Construct a new UpdateQueueOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        public UpdateQueueOptions(string pathSid)
        {
            PathSid = pathSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            
            if (MaxSize != null)
            {
                p.Add(new KeyValuePair<string, string>("MaxSize", MaxSize.Value.ToString()));
            }
            
            return p;
        }
    }

    /// <summary>
    /// Remove an empty queue
    /// </summary>
    public class DeleteQueueOptions : IOptions<QueueResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Delete by unique queue Sid
        /// </summary>
        public string PathSid { get; }
    
        /// <summary>
        /// Construct a new DeleteQueueOptions
        /// </summary>
        ///
        /// <param name="pathSid"> Delete by unique queue Sid </param>
        public DeleteQueueOptions(string pathSid)
        {
            PathSid = pathSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// Retrieve a list of queues belonging to the account used to make the request
    /// </summary>
    public class ReadQueueOptions : ReadOptions<QueueResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

    /// <summary>
    /// Create a queue
    /// </summary>
    public class CreateQueueOptions : IOptions<QueueResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// A user-provided string that identifies this queue.
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// The max number of calls allowed in the queue
        /// </summary>
        public int? MaxSize { get; set; }
    
        /// <summary>
        /// Construct a new CreateQueueOptions
        /// </summary>
        ///
        /// <param name="friendlyName"> A user-provided string that identifies this queue. </param>
        public CreateQueueOptions(string friendlyName)
        {
            FriendlyName = friendlyName;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            
            if (MaxSize != null)
            {
                p.Add(new KeyValuePair<string, string>("MaxSize", MaxSize.Value.ToString()));
            }
            
            return p;
        }
    }

}