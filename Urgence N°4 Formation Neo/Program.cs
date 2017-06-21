using System;

namespace Urgence_N_4_Formation_Neo
{
    class Program
    {
        /* Encore une fois nous avons besoin de vous en urgence...
         * Le hacker qui a détruit notre système informatique nous a envoyé un message.
         * Connaissez vous le chiffrement de César? Parfait!
         * Son message est crypté avec cette méthode, à vous de le décrypter pour savoir ce qu'il nous veut !
         * 
         * Au cas où, le chiffrement de César est un chiffrement par décallage.
         * En utilisant les fonctions fournies, à vous de déchiffrer le message codé!
         * 
         * Pour plus se simplicité, ce message ne contiendra pas de ponctuation ni accent,
         * et sera écrit en minuscule. Il y aura tout de même des espaces (on est pas
         * sur Twitter!). A vous de vous renseigner pour savoir comment 
         * parcourir une string pour y trouver chaque élément, puis comment
         * remplacer chaque lettre par son équivalent...
         * 
         * TIPS : C'est quoi la table ASCII? Et une string, ne serait-ce pas une chaine de char?
         * Si on utilise une string comme un tableau de char, il est facile de le parcourir...
         * 
         * Attention, le décallage peut être négatif, ou supérieur à 26! Attention à votre décallage!
        */
        static void Main(string[] args)
        {
            string Message = "jz kl rj ivljjz r uvtipgkvi tr kl rj ul gfkvekzvc kl mrj mfzi fe mr szve izxfcvi sffg";

            Console.WriteLine(ChiffrementDeCesar(Message, 9));
        }

        static string ChiffrementDeCesar(string message, int decallage)
        {
            string NewMessage = "";

            // L'alphabet en entier!
            char[] alpha = { 'a', 'b', 'c', 'd', 'e', 'f', 'g',
                             'h', 'i', 'j', 'k', 'l', 'm', 'n',
                             'o', 'p', 'q', 'r', 's', 't', 'u',
                             'v', 'w', 'x', 'y', 'z' };

            // Votre code ici!

            return NewMessage;
        }
    }
}
