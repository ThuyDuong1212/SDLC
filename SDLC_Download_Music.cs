namespace SDLC_Download_Music
{
    class Program
    {
        static void Main(string[] args)
        {
            char name_of_music = Convert.ToChar(Console.Readline());
            bool request_download;
            bool music_available;
            bool account_subcriptions;

            if (account_subcriptions = true)
            {
                name_of_music = true;
            }
            else
            {
                name_of_music = false;
            }

            if (name_of_music == DB.name_of_music)
            {
                request_download = true;
                show.message("Please wait a second, the song will be downloading...");
            }
            else
            {
                request_download = false;
                show.message("We can not find a song you want, please try again!");
            }
        }
    }
}


