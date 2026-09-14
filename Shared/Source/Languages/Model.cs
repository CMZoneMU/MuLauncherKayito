using System;
using System.Collections.Generic;

namespace Shared.Languages
{
	public static class LanguageModel
	{
		public static Dictionary<string, Dictionary<string, string>> translations =
		    new Dictionary<string, Dictionary<string, string>>
		    {
			    // Spanish
			    ["Spn"] = new Dictionary<string, string>
			    {
				    // Main Form
				    ["PLAY_TXT"] = "Jugar",
				    ["CLOSE_TXT"] = "Cerrar",
				    ["OPTIONS_TXT"] = "Opciones",
				    ["WEB_TXT"] = "Web",

				    // Options Form
				    ["CONFIGURATIONS_TXT"] = "Configuraciones del juego",
				    ["USER_TITLE"] = "USUARIO",
				    ["USER_TXT"] = "Cuenta",
				    ["GRAPHICS_TITLE"] = "GRÁFICOS",
				    ["RESOLUTION_TXT"] = "Resolución",
				    ["WINDOWMODE_TXT"] = "Modo Ventana",
				    ["SOUND_TITLE"] = "SONIDO",
				    ["SOUND_TXT"] = "Sonidos",
				    ["MUSIC_TXT"] = "Música",
				    ["VOLUME_TXT"] = "Volumen",
				    ["LANGUAGE_TITLE"] = "IDIOMA",
				    ["LANGUAGE_TXT"] = "Idioma",
				    ["SAVE_TXT"] = "Guardar",

				    // Status
				    ["UPDATE_CONNECTING"] = "Conectando...",
				    ["UPDATE_DOWNLOADING_MANIFEST"] = "Descargando información...",
				    ["UPDATE_SCANNING"] = "Escaneando archivos locales...",
				    ["UPDATE_CHECKING"] = "Verificando {0}/{1}: {2}",
				    ["UPDATE_CHECKING_RESULT"] = "{0} archivos necesitan actualizarse",
				    ["UPDATE_DOWNLOADING"] = "Descargando {0}",
				    ["UPDATE_COMPLETE"] = "Actualización completa",
			    },

			    // Portuguese
			    ["Por"] = new Dictionary<string, string>
			    {
				    // Main Form
				    ["PLAY_TXT"] = "Jogar",
				    ["CLOSE_TXT"] = "Fechar",
				    ["OPTIONS_TXT"] = "Opções",
				    ["WEB_TXT"] = "Web",

				    // Options Form
				    ["CONFIGURATIONS_TXT"] = "Configurações do jogo",
				    ["USER_TITLE"] = "USUÁRIO",
				    ["USER_TXT"] = "Conta",
				    ["GRAPHICS_TITLE"] = "GRÁFICOS",
				    ["RESOLUTION_TXT"] = "Resolução",
				    ["WINDOWMODE_TXT"] = "Modo Janela",
				    ["SOUND_TITLE"] = "SOM",
				    ["SOUND_TXT"] = "Sons",
				    ["MUSIC_TXT"] = "Música",
				    ["VOLUME_TXT"] = "Volume",
				    ["LANGUAGE_TITLE"] = "LINGUAGEM",
				    ["LANGUAGE_TXT"] = "Linguagem",
				    ["SAVE_TXT"] = "Manter",

				    // Status
				    ["UPDATE_CONNECTING"] = "Conectando...",
				    ["UPDATE_DOWNLOADING_MANIFEST"] = "Baixando informações...",
				    ["UPDATE_SCANNING"] = "Analisando arquivos locais...",
				    ["UPDATE_CHECKING"] = "Verificando {0}/{1}: {2}",
				    ["UPDATE_CHECKING_RESULT"] = "{0} arquivos precisam ser atualizados",
				    ["UPDATE_DOWNLOADING"] = "Baixando {0}",
				    ["UPDATE_COMPLETE"] = "Atualização completa",
			    },

			    // English (default)
			    ["Eng"] = new Dictionary<string, string>
			    {
				    // Main Form
				    ["PLAY_TXT"] = "Play",
				    ["CLOSE_TXT"] = "Close",
				    ["OPTIONS_TXT"] = "Options",
				    ["WEB_TXT"] = "Web",

				    // Options Form
				    ["CONFIGURATIONS_TXT"] = "Configurations of the game",
				    ["USER_TITLE"] = "USER",
				    ["USER_TXT"] = "Account",
				    ["GRAPHICS_TITLE"] = "GRAPHICS",
				    ["RESOLUTION_TXT"] = "Resolution",
				    ["WINDOWMODE_TXT"] = "Window Mode",
				    ["SOUND_TITLE"] = "SOUND",
				    ["SOUND_TXT"] = "Sounds",
				    ["MUSIC_TXT"] = "Music",
				    ["VOLUME_TXT"] = "Volume",
				    ["LANGUAGE_TITLE"] = "LANGUAGE",
				    ["LANGUAGE_TXT"] = "Language",
				    ["SAVE_TXT"] = "Save",

				    // Status
				    ["UPDATE_CONNECTING"] = "Connecting...",
				    ["UPDATE_DOWNLOADING_MANIFEST"] = "Downloading manifest...",
				    ["UPDATE_SCANNING"] = "Scanning local files...",
				    ["UPDATE_CHECKING"] = "Checking {0}/{1}: {2}",
				    ["UPDATE_CHECKING_RESULT"] = "{0} files need update",
				    ["UPDATE_DOWNLOADING"] = "Downloading {0}",
				    ["UPDATE_COMPLETE"] = "Update complete",
			    }
		    };
	}
}
