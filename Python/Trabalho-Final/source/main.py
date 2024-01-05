import pygame
import pygame_menu

from Definitions_Variables.dimension import get_dimensions
from Definitions_Variables.definitions import settings
from Game.game import start_game



pygame.init()



#obter dimensão da janela
width, height = get_dimensions()
surface = pygame.display.set_mode((width, height))


#mostrar o menu
menu = pygame_menu.Menu('Hungry Balls', width, height,
                       theme=pygame_menu.themes.THEME_GREEN)
menu.add.button('Jogar', start_game)
menu.add.button('Definições', settings)
menu.add.button('Sair', pygame_menu.events.EXIT)



menu.mainloop(surface)