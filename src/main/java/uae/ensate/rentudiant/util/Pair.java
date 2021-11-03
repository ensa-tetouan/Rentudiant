package uae.ensate.rentudiant.util;

import lombok.AllArgsConstructor;
import lombok.Getter;

@Getter
@AllArgsConstructor
public class Pair<T, U> {
    private final T p1;
    private final U p2;
}
