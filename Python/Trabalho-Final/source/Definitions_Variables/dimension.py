from screeninfo import get_monitors



def get_dimensions():
    monitors = get_monitors()


    if monitors:
        first_monitor = monitors[0]
        return first_monitor.width, first_monitor.height

    else:
        return 800, 600