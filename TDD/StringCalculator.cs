﻿namespace TTD;

public class StringCalculator {
    public int Add(string s) {
        if (s == string.Empty) {
            return 0;
        }
        return int.Parse(s);
    }
}

