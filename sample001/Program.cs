
//double m = Convert.ToDouble();

int mass=1000;
int[] RS =new int [mass];
double mean=0;
double sum=0;
double stddev=0;
double stddev2=0;

int i=0;

for(i=0; i<mass;i++)
    {
    Random rnd = new Random();
        RS [i] = rnd.Next(100);
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



