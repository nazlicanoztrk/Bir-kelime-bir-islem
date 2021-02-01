using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using birkelimebirislemn.islemler.sayi

namespace birkelimebirislemn
{
    public class CountdownNumber
    {
//        public class MYCLASSNAME : MonoBehaviour
//        {
//            FIXME_VAR_TYPE numbers = new Array(5);
//            FIXME_VAR_TYPE twoDigitsNumber;
//            FIXME_VAR_TYPE targetNumber;

//for(FIXME_VAR_TYPE i= 0;i<numbers.length;i++)
//{
//    numbers[i] = Math.floor((Math.random() * 9) + 1);
//}

//        twoDigitsNumber = Math.floor((Math.random() * 9) + 1)*10;
//targetNumber = Math.floor((Math.random() * 899) + 100);

//numbers.push(twoDigitsNumber);

//document.getElementById("Numbers").innerHTML = "Given Numbers = {"+numbers.sort(function(a, b){return a-b
//    }).valueOf()+"}";

//document.getElementById("Target").innerHTML = "Target Number: "+ targetNumber;

//FIXME_VAR_TYPE solutions = SolveTrees(numbers, targetNumber);

//    solutions.forEach(solution => {

//    document.getElementById("Result").innerHTML += "<br>"+ solution;

//});

//void SolveTrees(numbers, targetNumber)
//{
//    FIXME_VAR_TYPE output = [];
//    FIXME_VAR_TYPE nodes = [];
//    numbers.forEach(numberInOperation =>
//    {
//        nodes.push(new Node(numberInOperation));
//    });

//    FIXME_VAR_TYPE allTrees = CreateTrees(nodes);

//    FIXME_VAR_TYPE bestTrees = [];
//    FIXME_VAR_TYPE minDifference = 999;
//    allTrees.forEach(nodeInOperation =>
//    {
//        FIXME_VAR_TYPE e = nodeInOperation.evaluate();
//        FIXME_VAR_TYPE difference = Math.abs(e - targetNumber);
//        if (difference < minDifference)
//        {
//            bestTrees.splice(0, bestTrees.length);
//            minDifference = difference;
//            bestTrees.push(nodeInOperation);
//        }
//        else if (difference == minDifference)
//        {
//            bestTrees.push(nodeInOperation);
//        }
//    });
//    bestTrees.forEach(nodeInOperation =>
//    {

//        if (output.indexOf(nodeInOperation + " = " + nodeInOperation.evaluate()) == -1)
//        {
//            output.push(nodeInOperation + " = " + nodeInOperation.evaluate());
//        }
//    });
//    return output;
//}

//void CreateTrees(nodes)
//{
//    if (nodes.length === 1)
//    {
//        return nodes;
//    }
//    FIXME_VAR_TYPE result = nodes.slice(0);

//    nodes.forEach(node =>
//    {

//        FIXME_VAR_TYPE copy = nodes.slice(0);
//        copy.splice(copy.indexOf(node), 1);

//        FIXME_VAR_TYPE others = CreateTrees(copy);

//        others.forEach(other =>
//        {

//            result.push(new Node(null, node, '+', other));
//            result.push(new Node(null, node, '*', other));
//            result.push(new Node(null, node, '-', other));
//            result.push(new Node(null, other, '-', node));

//            FIXME_VAR_TYPE vNode = node.evaluate();
//            FIXME_VAR_TYPE vOther = other.evaluate();

//            if (vOther !== 0 && vNode % vOther === 0)
//            {
//                result.push(new Node(null, node, '/', other));
//            }
//            if (vNode !== 0 && vOther % vNode === 0)
//            {
//                result.push(new Node(null, other, '/', node));
//            }
//        });
//    });
//    return result;
//};

//void Node(value, left, op, right)
//{
//    this.value = value;
//    this.left = left;
//    this.op = op;
//    this.right = right;
//    this.evaluate = function(){
//        if (this.op != null)
//        {
//            FIXME_VAR_TYPE lv = this.left.evaluate();
//            FIXME_VAR_TYPE rv = this.right.evaluate();
//            if (this.op == '+')
//            {
//                return lv + rv;
//            }
//            else if (this.op == '-')
//            {
//                return lv - rv;
//            }
//            else if (this.op == '*')
//            {
//                return lv * rv;
//            }
//            else if (this.op == '/')
//            {
//                return lv / rv;
//            }
//        }
//        return this.value;
//    }
//    this.toString = function(){
//        if (this.op == null)
//        {
//            return this.value;
//        }
//        return "(" + this.left.toString() + this.op + this.right.toString() + ")";//
//    }
//}
//}
//    }
}
