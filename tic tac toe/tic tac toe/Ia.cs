using System;
using System.Collections.Generic;
using System.IO;

namespace tic_tac_toe
{
    public class Ia
    {
        public int presqueGagner(List<int> liste)
        {
            #region horizontal
            if (liste[0] == liste[1] && liste[0] != 0)
            {
                if (liste[2] == 0 )
                    return 2;
            }
            else if (liste[1] == liste[2] && liste[1] != 0)
            {
                if (liste[0] == 0)
                    return 0;
            }
            else if (liste[0] == liste[2] && liste[2] != 0)
            {
                if (liste[1] == 0)
                    return 1;
            }
            else if (liste[3] == liste[4] && liste[3] != 0)
            {
                if (liste[5] == 0)
                    return 5;
            }
            else if (liste[4] == liste[5] && liste[4] != 0)
            {
                if (liste[3] == 0)
                    return 3;
            }
            else if (liste[3] == liste[5] && liste[5] != 0)
            {
                if (liste[4] == 0)
                    return 4;
            }
            else if (liste[6] == liste[7] && liste[6] != 0)
            {
                if (liste[8] == 0)
                    return 8;
            }
            else if (liste[7] == liste[8] && liste[7] != 0)
            {
                if (liste[6] == 0)
                    return 6;
            }
            else if (liste[6] == liste[8] && liste[8] != 0)
            {
                if (liste[7] == 0)
                    return 7;
            }
            #endregion

            #region vertical
            if (liste[0] == liste[3] && liste[0] != 0)
            {
                if (liste[6] == 0)
                    return 6;
            }
            else if (liste[3] == liste[6] && liste[3] != 0)
            {
                if (liste[0] == 0)
                    return 0;
            }
            else if (liste[0] == liste[6] && liste[6] != 0)
            {
                if (liste[3] == 0)
                    return 3;
            }
            else if (liste[1] == liste[4] && liste[1] != 0)
            {
                if (liste[7] == 0)
                    return 7;
            }
            else if (liste[4] == liste[7] && liste[4] != 0)
            {
                if (liste[1] == 0)
                    return 1;
            }
            else if (liste[1] == liste[7] && liste[7] != 0)
            {
                if (liste[4] == 0)
                    return 4;
            }
            else if (liste[2] == liste[5] && liste[5] != 0)
            {
                Console.WriteLine("ckifji");
                if (liste[8] == 0)
                    return 8;
            }
            else if (liste[5] == liste[8] && liste[5] != 0)
            {
                Console.WriteLine("ckifji");
                if (liste[2] == 0)
                    return 2;
            }
            else if (liste[2] == liste[8] && liste[8] != 0)
            {
                if (liste[5] == 0)
                    return 5;
            }
            #endregion

            #region diagonal
            if (liste[0] == liste[4] && liste[0] != 0)
            {
                if (liste[8] == 0)
                    return 8;
            }
            else if (liste[4] == liste[8] && liste[4] != 0)
            {
                if (liste[0] == 0)
                    return 0;
            }
            else if (liste[0] == liste[8] && liste[8] != 0)
            {
                if (liste[4] == 0)
                    return 4;
            }
            else if (liste[2] == liste[4] && liste[2] != 0)
            {
                if (liste[2] == 0)
                    return 6;
            }
            else if (liste[2] == liste[6] && liste[6] != 0)
            {
                if (liste[4] == 0)
                    return 4;
            }
            else if (liste[6] == liste[4] && liste[4] != 0)
            {
                if (liste[2] == 0)
                    return 2;
            }
            #endregion

            return -1;
        }

        public int gagner(List<int> liste)
        {
            #region horizontal
            if (liste[0] == liste[1] && liste[0] == liste[2] && liste[0] != 0)
            {
                if(liste[0] == 1)
                    return 1;
                else
                    return 2;
            }
            else if (liste[3] == liste[4] && liste[4] == liste[5] && liste[3] != 0)
            {
                if (liste[3] == 1)
                    return 1;
                else
                    return 2;
            }
            if (liste[6] == liste[7] && liste[7] == liste[8] && liste[6] != 0)
            {
                if (liste[6] == 1)
                    return 1;
                else
                    return 2;
            }
            #endregion

            #region vertical
            if (liste[0] == liste[3] && liste[3] == liste[6] && liste[0] != 0)
            {
                if (liste[0] == 1)
                    return 1;
                else
                    return 2;
            }
            else if (liste[1] == liste[4] && liste[4] == liste[7] && liste[1] != 0)
            {
                if (liste[4] == 1)
                    return 1;
                else
                    return 2;
            }
            if (liste[2] == liste[5] && liste[5] == liste[8] && liste[2] != 0)
            {
                if (liste[5] == 1)
                    return 1;
                else
                    return 2;
            }
            #endregion

            #region diagonale
            if (liste[0] == liste[4] && liste[4] == liste[8] && liste[0] != 0)
            {
                if (liste[4] == 1)
                    return 1;
                else
                    return 2;
            }
            else if (liste[2] == liste[4] && liste[4] == liste[6] && liste[6] != 0)
            {
                if (liste[2] == 1)
                    return 1;
                else
                    return 2;
            }
            #endregion

            return 0;
        }
    }
}
