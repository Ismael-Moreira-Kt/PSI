import tkinter as tk
from PIL import Image, ImageTk

from Definitions_Variables.settings import settings
from Definitions_Variables.dimension import get_dimensions
from Definitions_Variables.play_sound import play_sound 
from Game.game import game



def quitGame():
    play_sound("Assets/audio/exit.mp3")
    root.after(1250)
    root.destroy() 



root = tk.Tk()
root.title("Hungry Balls")


# Colocar a janela em fullscreen
width, height = get_dimensions()
root.geometry(f"{width}x{height}")


# Colocar uma imagem de fundo
background_image = Image.open("Assets/images/background.jpeg")
background_image = background_image.resize((width, height))
background_photo = ImageTk.PhotoImage(background_image)

background_label = tk.Label(root, image=background_photo)
background_label.place(x=0, y=0, relwidth=1, relheight=1)


# Importar os ícones
playIcon = Image.open("Assets/images/play.png")
playIcon = playIcon.resize((30, 30))
playIcon = ImageTk.PhotoImage(playIcon)

settingsIcon = Image.open("Assets/images/settings.png")
settingsIcon = settingsIcon.resize((30, 30))
settingsIcon = ImageTk.PhotoImage(settingsIcon)

quitIcon = Image.open("Assets/images/logout.png") 
quitIcon = quitIcon.resize((30, 30))  
quitIcon = ImageTk.PhotoImage(quitIcon)


# Criar uma fonte customizada
custom_font = ('Arial', 18, 'bold')

# Criar um frame para os botões
button_frame = tk.Frame(root)
button_frame.pack(pady=(height//4, 0))


# Criar e mostrar os botões no frame
playButton = tk.Button(button_frame, anchor="w", text="Jogar", font=custom_font, image=playIcon, compound="left", bd=0, highlightthickness=0, width=200, pady=30, command=game)
settingsButton = tk.Button(button_frame, anchor="w", text="Configurações", font=custom_font, image=settingsIcon, compound="left", bd=0, highlightthickness=0, width=200, pady=30, command=settings)
quitButton = tk.Button(button_frame, anchor="w", text="Sair", font=custom_font, image=quitIcon, compound="left", bd=0, highlightthickness=0, width=200, pady=30, command=quitGame)

# O tkinter não suporta transparencia :(
playButton.config(bg="#FFFFF0")
settingsButton.config(bg="#FFFFF0")
quitButton.config(bg="#FFFFF0")

playButton.pack()
settingsButton.pack()
quitButton.pack()



root.mainloop()