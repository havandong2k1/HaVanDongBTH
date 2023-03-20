namespace baithuchanh0703.Models.Process;

    public class Giaiphuongtrinhbachai
    {
        public string Phuongtrinhbachai( double a, double b, double c)

        {
            double delta, x1, x2;
            string ketqua;
            delta = Math.Pow(b,2) - 4 * a * c;
                if(delta<0) ketqua ="Phuong trinh vo nhiem ";
                else if (delta==0)
                {
                    x1 = -b /(2*a);
                    ketqua ="phuong trinh co nghiem kep là: " + x1;
                }
                else
                {
                    x1 = (-b +  Math.Sqrt(delta))/(2*a);
                    x2 = (-b +  Math.Sqrt(delta))/(2*a);
                    ketqua = "Phuong trinh co 2 hai nghiem phaan biet: X1= " + x1 +  ", X2 = "+ x2;
                    
                }
                return ketqua;
            
        }
    }
