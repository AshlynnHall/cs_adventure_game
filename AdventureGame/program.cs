using System;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName;

            Console.WriteLine("Welcome to this adventure game, where the choices you make matter.");
            Console.Write("Enter your name: ");
            playerName = Console.ReadLine();

            Console.WriteLine($"Hello, {playerName}. Your adventure begins now...");
            StartStory();
        }

        static void StartStory()
        {
            Console.WriteLine("You're driving to a party at a cabin in the woods when your car comes sputtering to a halt. You check");
            Console.WriteLine("your phone; you have no service and you're still a 20 minute drive from the party. It's dark and you");
            Console.WriteLine("haven't seen another car in a few miles. What do you do?");
            Console.WriteLine("1. Stay put and try to flag someone driving by for help.");
            Console.WriteLine("2. Start walking towards the party.");
            MakeChoice(new Action[] { StayPut, StartWalking });
        }

        static void StartWalking()
        {
            Console.WriteLine("You start walking towards the party. It's a bit chilly and the noises in the forest have you");
            Console.WriteLine("feeling very anxious. You try to stay positive until you hear rustling in the bushes just in");
            Console.WriteLine("front of you. You know that there's all kinds of wildlife in these woods. What do you do?");
            Console.WriteLine("1. Start running.");
            Console.WriteLine("2. Stand still until the noise stops.");
            MakeChoice(new Action[] { StartRunning, StandStill });
        }

        static void StayPut()
        {
            Console.WriteLine("You sit in your car for 10 minutes when you hear a car approaching. You jump out and begin waving");
            Console.WriteLine("your arms. The car zooms past without slowing down. You huff and sit down until you hear another");
            Console.WriteLine("car approaching. You flail your arms again and the car pulls over behind you. An elderly man with");
            Console.WriteLine("a limp and an eye patch gets out and approaches you. After explaining your situation he offers to finish");
            Console.WriteLine("driving you to the party since it's on his way, but requests you pay him $50.");
            Console.WriteLine("1. Take the ride and pay him.");
            Console.WriteLine("2. Wait for another car.");
            MakeChoice(new Action[] { TakeTheRide, Wait });
        }

        static void StartRunning()
        {
            Console.WriteLine("You begin sprinting down the road as fast as you can using the moonlight to see. The wind in your ears makes it hard to hear");
            Console.WriteLine("so you turn your head around but you don't see anything. You're feeling breathless and tired when");
            Console.WriteLine("you trip forward hard. You skin your hands and your elbows are bleeding. You check behind you");
            Console.WriteLine("and see a dark object down the road in the moonlight.");
            Console.WriteLine("1. Hide.");
            Console.WriteLine("2. Run through the pain.");
            MakeChoice(new Action[] { Hide, GetUp });
        }

        static void StandStill()
        {
            Console.WriteLine("You stand as still as you can; you can hear your own heartbeat as you stand in a bundle of nerves.");
            Console.WriteLine("After a solid minute of an approaching rustling, a jack rabbit hops out into the road. You breathe");
            Console.WriteLine("a heavy sigh as it jumps across the road into more trees. You keep walking nervous, tired, and");
            Console.WriteLine("overwhelmed. A couple cars pass but no one stops until you hear a familiar yell from some boys you know.");
            Console.WriteLine("'What're you doing??? Hop in the bed of the truck! We're almost to the party' one of them yells. You");
            Console.WriteLine("jump in the back and hold on for 10 minutes until you roll down a dirt road toward a cabin surrounded");
            Console.WriteLine("by cars and shaking with loud music. You finally have a bit of cell service.");
            Console.WriteLine("1. Call for someone to bring you gas.");
            Console.WriteLine("2. Just enjoy the party and worry later.");
            MakeChoice(new Action[] { CallForHelp, WorryLater });
        }

        static void TakeTheRide()
        {
            Console.WriteLine("You give the old man $50 in cash. You ride together in silence, the old man following");
            Console.WriteLine("the directions on the GPS. Eventually, you pull up to an old creepy cabin with a few cars outside.");
            Console.WriteLine("'Thanks for the ride,' you tell the old man as you hop out of his truck. You hear his car pull away");
            Console.WriteLine("as you knock on the front door. Lo and behold, your friend Carter opens the door! He grins");
            Console.WriteLine("'Thank goodness, someone said they saw your car on the side of the road!' He directs you inside");
            Console.WriteLine("to a small gathering inside playing uno and talking about the new episodes of American Idol. Not quite");
            Console.WriteLine("the party you were expecting...");
        }

        static void Wait()
        {
            Console.WriteLine("You decline the ride and the man drives away. You wait another 20 minutes before you see another");
            Console.WriteLine("truck approaching. Waving it down, it stops and you realize it's a tow truck. A burly man steps out");
            Console.WriteLine("and tells you he received a call that someone had passed a broken down car about an hour ago. You");
            Console.WriteLine("tell him your situation and he shares that he has a few gallons of gas in his truck he can sell you");
            Console.WriteLine("for a slight upcharge and you accept. You fill up; it's enough gas to get you to either the party or");
            Console.WriteLine("the nearest gas station.");
            Console.WriteLine("1. Go to the party.");
            Console.WriteLine("2. Go to the gas station.");
            MakeChoice(new Action[] { GoParty, GetGas });
        }

        static void GoParty()
        {
            Console.WriteLine("You arrive at the party - late... but oh well! You dance and drink lemonade and try and enjoy");
            Console.WriteLine("your evening. Before you know it everyone is leaving. You get in your car to leave when the gas");
            Console.WriteLine("light indicator reminds you that you're on empty. You have to call a relative to bring you gas");
            Console.WriteLine("and don't get home until well past 4 AM. Your relative is annoyed, you're exhausted, and you swear");
            Console.WriteLine("that you'll always remember to fill up your car before leaving town again...");
        }

        static void GetGas()
        {
            Console.WriteLine("You drive to a gas station that's slightly out of the way from the party. Making you very late to");
            Console.WriteLine("the cabin... when you arrive though, you feel a weight off of your shoulders and relax. You");
            Console.WriteLine("dance and mingle and a group mentions that they're staying the night so they don't have to drive");
            Console.WriteLine("back so late and offer you a bed. You party late and sleep well in the wooded, quiet, cabin in the woods");
            Console.WriteLine("glad to know that your car is full for your drive back the next day...");
        }

        static void Hide()
        {
            Console.WriteLine("You hide in the nearby brush for nearly a half hour until you have the courage to reveal yourself");
            Console.WriteLine("and continue your trek. You walk the rest of the way to the party looking like a mess. You have dirt on your");
            Console.WriteLine("clothes, leaves in your hair, and blood running down your arms. When you arrive at the party, you receive lots");
            Console.WriteLine("of looks from fellow party-goers but you brush them off. You clean up in the bathroom, try and enjoy yourself,");
            Console.WriteLine("have a friend go grab gasoline for you, and swear that you'll never forget to gas up your car again...");
        }

        static void GetUp()
        {
            Console.WriteLine("You run until you see the cabin in front of you. You bang on the door and someone you don't recognize swings it open.");
            Console.WriteLine("You run inside, slam the door behind you, and in between breaths tell this person that you were chased by a");
            Console.WriteLine("animal for miles. You look at their confused expression and then your eyes travel around the inside of the cabin");
            Console.WriteLine("There's no one else to be seen, no sign of an on-going party, and the unknown individual is dressed in pajamas.");
            Console.WriteLine("You're not as the right address. The person offers to let you call someone and wait to be picked up.");
            Console.WriteLine("You're embarassed, bloody, and more tired than you've ever been. Eventually, a friend picks you up, drives you");
            Console.WriteLine("to get gas and you drive home tired, scared, and a little bit humiliated...");
        }

        static void CallForHelp()
        {
            Console.WriteLine("You call your friend, who thankfully hasn't left yet. He offers to grab some gas and bring it with him");
            Console.WriteLine("so you can fill up on your way back. You try and loosen up and enjoy the party, sharing your scary");
            Console.WriteLine("encounter with the rabbit to all of your friends. You enjoy your time, fill your car up afterwards, and make");
            Console.WriteLine("it back home very late. You sleep very well knowing you're finally home...");
        }

        static void WorryLater()
        {
            Console.WriteLine("You decide to just let it go, party it up and worry about your car later. You dance all night");
            Console.WriteLine("and laugh with your friends. The night slips away and as people are leaving you remember that");
            Console.WriteLine("your car is on the side of the road miles away. You ask for rides, but no one is headed your direction.");
            Console.WriteLine("Eventually you find one person going to your neighborhood. Anxious Annie, offers to drop you off at your house");
            Console.WriteLine("and you take the ride, listening to her tell you about all of her preparations for a zombie apocolpyse.");
            Console.WriteLine("You head to bed, receiving a call the next morning that your car has been towed and impounded. You're tired,");
            Console.WriteLine("bugged, and now you owe Mike's Towing Services $400 to get your car back...");
        }

        static void MakeChoice(Action[] choices)
        {
            while (true)
            {
                Console.WriteLine("Enter your choice (1 or 2):");
                string input = Console.ReadLine(); 

                if (input == "1")
                {
                    choices[0]();
                    break;
                }
                else if (input == "2")
                {
                    choices[1]();
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid choice (1 or 2).");
                }
            }
        }
    }
}