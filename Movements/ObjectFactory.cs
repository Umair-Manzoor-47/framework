using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movements
{
    public class ObjectFactory
    { 
            // A private constructor to restrict the object creation from outside
            private ObjectFactory()
            {

            }

            // A private static instance of the same class
            private static ObjectFactory instance = null;

            internal static ObjectFactory GetInstance()
            {
                // create the instance only if the instance is null
                if (instance == null)
                {
                    instance = new ObjectFactory();
                }

                // Otherwise return the already existing instance
                return instance;
            }
        // List
        List<IMove> availableMovement = new List<IMove>();
        List<IMove> occupiedMovement = new List<IMove>();

        public IMove getMovementType(MovementType movementType)
        {

            IMove movement = movementExistOrNot(movementType);
            if (movement != null)
            {
                occupiedMovement.Add(movement);
                availableMovement.Remove(movement);
                return movement;
            }
            else
            {
                IMove createMovement;
                if (movementType == MovementType.Left)
                {
                    createMovement = new Left();
                    occupiedMovement.Add(createMovement);
                    return createMovement;
                }
                else if (movementType == MovementType.Right)
                {
                    createMovement = new Right();
                    occupiedMovement.Add(createMovement);
                    return createMovement;
                }
                else if (movementType == MovementType.Up)
                {
                    createMovement = new Up();
                    occupiedMovement.Add(createMovement);
                    return createMovement;
                }
                else if (movementType == MovementType.Down)
                {
                    createMovement = new Down();
                    occupiedMovement.Add(createMovement);
                    return createMovement;
                }
                else if (movementType == MovementType.MoveWithKey)
                {
                    createMovement = new MoveWithKey();
                    occupiedMovement.Add(createMovement);
                    return createMovement;
                }

            }
            return null;
        }
        private IMove movementExistOrNot(MovementType movementType)
        {

            foreach (IMove move in availableMovement)
            {
                if (move.getType() == movementType)
                {
                    return move;
                }

            }
            return null;
        }
        public void relase(IMove movementType)
        {
            occupiedMovement.Remove(movementType);
            availableMovement.Add(movementType);

        }
    }


}

