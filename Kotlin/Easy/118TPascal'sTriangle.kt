
fun generate(numRows: Int): List<List<Int>> {
    var res=ArrayList<List<Int>>()
    var preList=ArrayList<Int>()
    for (i in 1..numRows) {
        var list=ArrayList<Int>()
        if(i<2){
            for (t in 1..i) {
                list.add(1);
            }
        }else{
            list.add(1);
            for (t in 2..(i-1)) {
                list.add(preList.get(t-1)+preList.get(t-2))
            }
            list.add(1);
        }   
        preList=list     
        res.add(list)
    }
    return res
}