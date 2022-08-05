
//double m = Convert.ToDouble();



int mass=3;
double[] RS = new double[] { 0, 0, 0 };
//int[] RS =new int [mass];
RS[0]=261.21;
RS[1]=260.88;
RS[2]=261.27;
double mean=0;
double sum=0;
double stddev=0;
double stddev2=0;

int i=0;

for(i=0; i<mass;i++)
    {
    //Random rnd = new Random();
     //   RS [i] = rnd.Next(100);
        //RS [i] = rnd.Next(49,51);
    sum=sum+RS[i];
    }
    mean=sum/mass;
for(i=0; i<mass;i++)
    {
    stddev2=stddev2+(RS[i]-mean)*(RS[i]-mean);
    }
stddev=Math.Sqrt(stddev2);



Console.WriteLine(sum);
Console.WriteLine(mean);
Console.WriteLine(stddev2);
Console.WriteLine(stddev);



