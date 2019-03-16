package Vehicle;

import Vignette.Vignette;

public abstract class Vehicle {

    private String yearOfProduction;

    public Vehicle(String yearOfProduction) {
        this.yearOfProduction = yearOfProduction;
    }
    public abstract Vignette getVignette();
    public abstract int glueVignette (Vignette vignee) ;

    @Override
    public String toString() {
        return "Vehicle type: " + this.getClass().getSimpleName() + ". Year of production: " + yearOfProduction;
    }
}
