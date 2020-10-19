namespace StatesPattern
{
    /// <summary>
    /// 环境类(上下文)
    /// </summary>
    public class PlayContext
    {
        private PlayState curState, finalState, primaryState, professionState,secondState;

        public PlayContext()
        {
            finalState = new Final();
            primaryState = new Primary();
            professionState = new Professional();
            secondState = new Secondary();
        }

        public void SetState(PlayState state)
        {
            curState = state;
        }

        public void ChangeState(int playId,int playResult)
        {
            if (playId == 1)
            {
                SetState(primaryState);
            }
            else if (playId == 2)
            {
                SetState(secondState);
            }
            else if (playId == 3)
            {
                SetState(professionState);
            }
            else if (playId == 4)
            {
                SetState(finalState);
            }

            curState.Play();
            curState.DoubleScore(playResult);
            curState.ChangeCards();
            curState.PeekCards();

        }
    }
}
