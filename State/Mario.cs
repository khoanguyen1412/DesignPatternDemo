using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Mario
    {
        private IState state;

        public Mario()
        {
            state = new WalkState();
        }

        private void setState(IState newState)
        {
            state = newState;
        }

        public void Eat(Item item)
        {
            if (item == Item.Walk)
            {
                this.state = new WalkState();
            }
            else
            {
                this.state = new FlyState();
            }
        }

        public void Move()
        {
            state.Move();
        }
    }
}
