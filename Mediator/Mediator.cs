using System.Collections.Generic;
using static System.Console;

namespace Patterns
{
    interface ISender { void Send(string id, string message); }

    /// <summary>
    /// Register objects and send messages between them
    /// </summary>
    class Mediator : ISender
    {
        /// <summary>
        /// Container for all of objects of 'Instance' class
        /// </summary>
        Dictionary<string, Instance> instances = new Dictionary<string, Instance>();

        /// <summary>
        /// Construtor
        /// </summary>
        public Mediator() 
        {
            ForegroundColor = System.ConsoleColor.Green;
            WriteLine(ToString());
            ResetColor();
        }

        /// <summary>
        /// Register object of 'Instance' class and add to container 'instances'
        /// </summary>
        /// <param name="instance">Object of the 'Instance' class</param>
        public void Register(Instance instance)
        {
            instance.Register(this);
            instances.Add(instance.ID, instance);
        }

        /// <summary>
        /// Send message to specified object of 'Instance' class
        /// </summary>
        /// <param name="id">id of object</param>
        /// <param name="message">text message</param>
        public void Send(string id, string message) => instances[id].Recive(message);
    }

    /// <summary>
    /// Main test objects to send and received messages 
    /// </summary>
    class Instance : ISender
    {
        Mediator mediator;

        /// <summary>
        /// Id of 'Instance' object
        /// </summary>
        public string ID { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">object id like a text</param>
        public Instance(string id) { ID = id; }

        /// <summary>
        /// Registering mediator by the object
        /// </summary>
        /// <param name="mediator">mediator object</param>
        public void Register(Mediator mediator) => this.mediator = mediator;

        /// <summary>
        /// Send message to selected (id) object by another object of the same 'Instance' class
        /// </summary>
        /// <param name="id">destination object id</param>
        /// <param name="message">text message</param>
        public void Send(string id, string message)
        {
            WriteLine($"Sending from '{ID}' to '{id}' text message: '{message}'");

            mediator.Send(id, message);
        }

        /// <summary>
        /// Print received message
        /// </summary>
        /// <param name="message">received a message to print</param>
        public void Recive(string message) => WriteLine($"'{ID}' received text message: '{message}'");
    }
}
