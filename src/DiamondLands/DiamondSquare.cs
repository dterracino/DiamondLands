using System;

namespace DiamondLands
{
    public class DiamondSquare
    {
        public int[,] M;
        Random rng = null;
        int w = 0;

        private int random(int range)
        {
            return rng.Next(range);
        }

        public DiamondSquare(int size, int rngSeed)
        {
            M = new int[size, size];
            rng = new Random(rngSeed);
            w = size;
        }

        public void Generate(out int min, out int max, int rangeMax, bool loopHorizont, bool loopVertical)
        {
            min = rangeMax;
            max = 0;    //for averaging
            int range = rangeMax;   //range for random numbers
            for (int offset = w - 1;
                //side length must be >= 2 so we always have
                //a new value (if its 1 we overwrite existing values
                //on the last iteration)
                offset >= 2;
                //each iteration we are looking at smaller squares
                //diamonds, and we decrease the variation of the offset
                offset /= 2)
            {
                //half the length of the side of a square
                //or distance from diamond center to one corner
                //(just to make calcs below a little clearer)
                int offset_2 = offset / 2;

                //generate the new square values
                for (int x = 0; x < w - 1; x += offset) {
                    for (int y = 0; y < w - 1; y += offset) {
                        //x, y is upper left corner of square
                        //calculate average of existing corners
                        int avg =
                            M[x, y] +                   //top left
                            M[x + offset, y] +          //top right
                            M[x, y + offset] +          //lower left
                            M[x + offset, y + offset];  //lower right

                        avg /= 4;

                        //We calculate random value in range of 2h
                        //and then subtract h so the end value is
                        //in the range (-h, +h)
                        int temp = avg + random(range) - range / 2;

                        //center is average plus random offset
                        M[x + offset_2, y + offset_2] = temp;
                        if (temp < min)
                            min = temp;
                        if (temp > max)
                            max = temp;
                    } // for y
                } // for x

                //generate the diamond values
                //since the diamonds are staggered we only move x
                //by half side
                //NOTE: if the data shouldn't wrap then x < DATA_SIZE
                //to generate the far edge values
                for (int x = 0; x < w - 1; x += offset_2) {
                    //and y is x offset by half a side, but moved by
                    //the full side length
                    //NOTE: if the data shouldn't wrap then y < DATA_SIZE
                    //to generate the far edge values
                    for (int y = (x + offset_2) % offset; y < w - 1; y += offset) {
                        //x, y is center of diamond
                        //note we must use mod  and add DATA_SIZE for subtraction 
                        //so that we can wrap around the array to find the corners
                        int avg =
                                M[(x - offset_2 + w - 1) % (w - 1), y] + //left of center
                                M[(x + offset_2) % (w - 1), y] + //right of center
                                M[x, (y + offset_2) % (w - 1)] + //below center
                                M[x, (y - offset_2 + w - 1) % (w - 1)]; //above center                        
                        avg /= 4;

                        //new value = average plus random offset
                        //We calculate random value in range of 2h
                        //and then subtract h so the end value is
                        //in the range (-h, +h)
                        //avg = avg + _rnd.NextDouble() * 2 * h - h;
                        avg = avg + random(range) - range / 2;
                        
                        //update value for center of diamond
                        M[x, y] = avg;

                        if (avg < min)
                            min = avg;
                        if (avg > max)
                            max = avg;

                        //wrap values on the edges, remove
                        //this and adjust loop condition above
                        //for non-wrapping values.
                        if ((x == 0) && loopVertical)
                            M[w - 1, y] = avg;
                        if ((y == 0) && loopHorizont)
                            M[x, w - 1] = avg;
                    } // for x
                } // for y

                range = (int)(range * 0.65f);
            } // for offset
        } // Generate
    } // class
}
