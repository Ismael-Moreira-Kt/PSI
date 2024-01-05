from screeninfo import get_monitors



def obter_dimensoes():
    monitores = get_monitors()


    if monitores:
        primeiro_monitor = monitores[0]
        return primeiro_monitor.width, primeiro_monitor.height

    else:
        return 800, 600