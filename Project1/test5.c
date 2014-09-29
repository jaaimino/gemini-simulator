int main(void){
    int x = 3;
    int y = 0;
    int z;
    for(; y; x--){
        z = 2;
        y = x / z;
        z = z + x;
        if(y == 9) {
            y = z * 256 + x * 257;
            goto rehash;
        }
    }
    rehash:
        y = (y & x) & (x | y);
    out:
     // Place y into the ACC to examine
}