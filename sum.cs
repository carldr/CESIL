        LOAD    0
LOOP    STORE   TOTAL
        IN
        JINEG   DONE
        ADD     TOTAL
        JUMP    LOOP

DONE    PRINT   "The total is: "
        LOAD    TOTAL
        OUT
        LINE
        HALT

        %
        1
        2
        3
        -1
