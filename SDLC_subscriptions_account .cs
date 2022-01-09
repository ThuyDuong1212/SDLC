namespace SDLC_subscriptions_account 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        {             
            char customer_id = Convert.ToChar(Console.ReadLine());             
            char customer_password = Convert.ToChar(Console.ReadLine());             
            bool login_status;             
            bool new_customer_status;             
            float account_balance;             
            char sub_date;             
            bool expiry_date;             
            bool subscriptions_status;             
            bool purchase_sub; 
 
            if ((customer_id == DB.customer_id) & (customer_password == DB.customer_password)) 
            {   show.message("Welcome to Tune Source"); 
                login_status = true; 
            }             
            else             
            { 
                login_status = false; 
                show.message(" Your ID or password is incorrect");             
            } 
 
            if ((login_status = true) & (new_customer_status = true)) 
            { 
                subscriptions_status = true; 
            } 
            else if (expiry_date = true) 
            { 
                subscriptions_status = true; 
            } 
            else if (purchase_sub = false) 
            { 
                show.message("Please subscribe to listen and download music"); 
            } 
            else if ( account_balance > DB.account_balance) 
            { 
                account_balance = account_balance - DB.account_balance;                
                subscriptions_status = true 
            }             
            else             
            { 
                show.message("Please Add money to your account"); 
            } 
        } 
    } 





