using System.Collections;

/// <summary>
/// This queue is circular.  When people are added via AddPerson, then they are added to the 
/// back of the queue (per FIFO rules).  When GetNextPerson is called, the next person
/// in the queue is saved to be returned and then they are placed back into the back of the queue.  Thus,
/// each person stays in the queue and is given turns.  When a person is added to the queue, 
/// a turns parameter is provided to identify how many turns they will be given.  If the turns is 0 or
/// less than they will stay in the queue forever.  If a person is out of turns then they will 
/// not be added back into the queue.
/// </summary>
public class TakingTurnsQueue //declares the class ttq
{
    private readonly  Queue<Person> _people= new();//initialized a private field(_people) of type PersonQueue, queue for managing persons objects.

    public int Length => _people.Count;//lenght returns the current length of the _people queue. => creates a property that returns value

    /// <summary>
    /// Add new people to the queue with a name and number of turns
    /// </summary>
    /// <param name="name">Name of the person</param>
    /// <param name="turns">Number of turns remaining</param>
    public void AddPerson(string name, int turns)//AddPerson takes a name and turns
    {
        var person = new Person(name, turns);//creates a new person object with the proved name and turns
        _people.Enqueue(person);//adds the created person to the back of the _people queue using the enqueue method
    }

    /// <summary>
    /// Get the next person in the queue and return them. The person should
    /// go to the back of the queue again unless the turns variable shows that they 
    /// have no more turns left.  Note that a turns value of 0 or less means the 
    /// person has an infinite number of turns.  An error exception is thrown 
    /// if the queue is empty.
    /// </summary>
    public Person GetNextPerson()//GetNextPerson returns a Person
    {
        if (_people.Count == 0)//checks if the _people queue is empty.
        {
            throw new InvalidOperationException("No one in the queue.");
        }

        Person person = _people.Dequeue();//removes and retrieves the next person from the front of _people
        if (person.Turns > 0)
        {
            person.Turns -= 1;
            if (person.Turns > 0)
            {
            _people.Enqueue(person);
            }
        }
        else
        {
            _people.Enqueue(person);
        }

        return person;//checks if the person has more thanone turn left
        
    }

    public override string ToString()//overrides the ToString method to return _people queue
    {
        return string.Join(", ", _people.Select(p => p.Name + "(" + p.Turns + ")"));
    }
}