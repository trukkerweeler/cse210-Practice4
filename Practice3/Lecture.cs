using System;

namespace Practice3
{
    public class Lecture : Event
    {
        private string _speaker;
        private int _capacity;

        public Lecture()
        {

        }
        public string PrintLecture()
        {
            //Console.WriteLine($"{GetTitle()} {GetDesc()} {GetDate()} {GetTime()} {GetAddress()} {GetSpeaker()} {GetCapacity()}");
            return $"{GetTitle()} {GetDesc()} {GetDate()} {GetTime()} {GetAddress()} {GetSpeaker()} {GetCapacity()}";

        }

        //Getters
        public string GetSpeaker()
        {
            return _speaker;
        }
        public int GetCapacity()
        {
            return _capacity;
        }

        //Setters
        public void SetSpeaker(string speaker)
        {            
            _speaker = speaker;
        }
        public void SetCapacity(int capacity)
        {
            _capacity = capacity;
        }
    }
}
