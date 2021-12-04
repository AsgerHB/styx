using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueText
{ 
    public static string[] INTRODUCTION = {
@"<color=grey>Passenger:</color>

<color=blue>I didn't do it...</color>",

@"<color=grey>Charon:</color>

<color=red>What?</color>",

@"<color=grey>Passenger:</color>

<color=blue>I didn't kill her.</color>",

@"<color=grey>Charon:</color>

<color=red>I believe you...</color>",

@"<color=grey>Passenger:</color>

<color=blue>The jury didn't. They sentenced me to life in prison. I was 18!</color>",

@"<color=grey>Passenger:</color>

<color=blue>That wasn't fast enough, so they sent me to the chair.</color>",

@"<color=grey>Charon:</color>

<color=red>You were not executed for her death. </color>",

@"<color=grey>Passenger:</color>

<color=blue>No, that was... That was something else.</color>",
    };


    public static string[][] HEAVEN = 
    {
         new string [] 
         { 

@"<color=grey>Passenger:</color>

<color=blue>Ah, you understand. Good.</color>",

@"<color=grey>Passenger:</color>

<color=blue>When we get to heaven, I'll take care of you.</color>",

@"<color=grey>Charon:</color>

<color=red>As you took care of your partner?</color>",

@"<color=grey>Passenger:</color>

<color=blue>I...</color>",

@"<color=grey>Passenger:</color>

<color=blue>He was a necessary sacrifice.</color>",

@"<color=grey>Passenger:</color>

<color=blue>When you fight a war, brothers become soldiers.</color>",

@"<color=grey>Charon:</color>

<color=red>All in the service of power.</color>",

@"<color=grey>Passenger:</color>

<color=blue>Spoken like someone who's always had it.</color>",
         },
         new string [] 
         { 

@"<color=grey>Passenger:</color>

<color=blue>Look, I'm not saying I'm perfect but...</color>",

@"<color=grey>Passenger:</color>

<color=blue>What do you do when a random stranger tries to hold you down?</color>",

@"<color=grey>Passenger:</color>

<color=blue>You make him stop.</color>",

@"<color=grey>Passenger:</color>

<color=blue>You make sure he can't try again.</color>",

@"<color=grey>Passenger:</color>

<color=blue>He wasn't supposed to die though.</color>",

@"<color=grey>Charon:</color>

<color=red>But he did.</color>",

@"<color=grey>Passenger:</color>

<color=blue>Well, I wasn't supposed to go to prison, but here we are.</color>",

         },
         new string [] 
         {
@"<color=grey>Passenger:</color>

<color=blue>Why did that stupid bastard have to try and stop me?</color>",

@"<color=grey>Passenger:</color>

<color=blue>When he grabbed me, I just saw them.</color>",

@"<color=grey>Passenger:</color>

<color=blue>My father, the judge, Isac... Those spineless prison bastards.</color>",

@"<color=grey>Passenger:</color>

<color=blue>I lost control. He didn't even make it to the hospital.</color>",

@"<color=grey>Passenger:</color>

<color=blue>Only took a couple of weeks to get the death sentence. </color>",

@"<color=grey>Passenger:</color>

<color=blue>I knew the exact date of my death and I could do nothing to stop it.</color>",

@"<color=grey>Passenger:</color>

<color=blue>...</color>",

@"<color=grey>Passenger:</color>

<color=blue>I've suffered enough, haven't I?</color>",
         },
         new string[] 
         {
@"<color=grey>Passenger:</color>

<color=blue>I'm finally home.</color>",
         }
    
    
    };


    public static string[][] HELL = 
    {
        new string [] 
        { 
@"<color=grey>Passenger:</color>

<color=blue>Look, you wouldn't be the first to think I belong in hell.</color>",


@"<color=grey>Passenger:</color>

<color=blue>But you don't know the whole story.</color>",


@"<color=grey>Charon:</color>

<color=red>I know all...</color>",


@"<color=grey>Passenger:</color>

<color=blue>Then you know that prison is a dog eat dog world.</color>",


@"<color=grey>Passenger:</color>

<color=blue>The dogs were circling and I wasn't to wait around for their bite.</color>",


@"<color=grey>Charon:</color>

<color=red>...</color>",


@"<color=grey>Passenger:</color>

<color=blue>I wasn't even supposed to be in jail in the first place!</color>",
        },
        new string [] 
        { 
@"<color=grey>Passenger:</color>

<color=blue>Understand, I have been under somebody's boot my entire life.</color>",

@"<color=grey>Passenger:</color>

<color=blue>My father, then the prison system... and then finally Isac.</color>",

@"<color=grey>Passenger:</color>

<color=blue>Until one day I snapped.</color>",

@"<color=grey>Passenger:</color>

<color=blue>Isac may have been a monster, but I had sharper teeth.</color>",

@"<color=grey>Passenger:</color>

<color=blue>Once the dust settled, hell became a paradise... For me.</color>",

@"<color=grey>Passenger:</color>

<color=blue>I felt powerful, in control.</color>",

@"<color=grey>Charon:</color>

<color=red>What about shame?</color>",

@"<color=grey>Passenger:</color>

<color=blue>I was done suffering.</color>",
        },
        new string [] 
        {

@"<color=grey>Charon</color>

<color=red>We're arriving at damnation.</color>",

@"<color=grey>Passenger:</color>

<color=blue>Honestly, what did you expect of me?</color>",

@"<color=grey>Passenger:</color>

<color=blue>I admit, I haven't lived the cleanest life. But, how could I?</color>",

@"<color=grey>Passenger:</color>

<color=blue>My entire life has been covered in filth.</color>",

@"<color=grey>Charon:</color>

<color=red>You could have washed it clean.</color>",

@"<color=grey>Passenger:</color>

<color=blue>The prison? I was just a man!</color>",

@"<color=grey>Charon:</color>

<color=red>You were a king.</color>",

@"<color=grey>Passenger:</color>

<color=blue>...</color>",

@"<color=grey>Passenger:</color>

<color=blue>Hahahaha!</color>",

@"<color=grey>Passenger:</color>

<color=blue>So was Isac, so was the bastard that replaced me.</color>",

@"<color=grey>Passenger:</color>

<color=blue>But you're right.</color>",

@"<color=grey>PASSENGER</color>

I should have saved them from the hell they created for themselves. ",

@"<color=grey>Passenger:</color>

<color=blue>It is a burden, us, the powerful must bear: compassion.</color>",

@"<color=grey>Passenger:</color>

<color=blue>Don't you agree, ferry man?</color>",
        },
        new string[] 
        {
@"<color=grey>Passenger:</color>

<color=blue>It will never end, will it?</color>",
        }
    };
}
