namespace HelloPullRequest
{
    public abstract class Person
    {
        public virtual bool CanSpeak()
        {
            return false;
        }

        public abstract void Speak();
    }
}