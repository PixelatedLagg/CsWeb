using CsWeb;

namespace Testing
{
    public class Program
    {
        public static void Main()
        {
            
        }
    }

    public class Homepage(ElementAttribute[] attributes) : IComponent
    {
        public ElementAttribute[] Attributes { get => _Attributes; set => _Attributes = value; }
        private ElementAttribute[] _Attributes = attributes;

        public string Render()
        {
            return
            $@"
            <div class='content'>
                <div className='text'>
                    <h1>Welcome to MathInfo.org</h1>
                    <p>testing!!!</p>
                    {new TestInsert() + [("style", "lmao!")]}
                </div>
            </div>
            ";
        }
    }

    public class TestInsert(params ElementAttribute[] attributes) : IComponent
    {
        public ElementAttribute[] Attributes { get => _Attributes; set => _Attributes = value; }
        private ElementAttribute[] _Attributes = attributes;

        public string Render()
        {
            return "<p>LMAOOOOO! Insert!</p>";
        }
    }
}

/*
import './index.css';
import React from 'react';

export default function Home(props) {
    document.title = "Home";
    props.onSetNames("Home");
    props.onSetLinks("/");
    return (
        <div className="content" role="main">
            <div className="text">
                <h1>Welcome to MathInfo.org</h1>
                <p>Here you will find (mainly article-based) resources for Mathematics and Computer Science, along with some interactive </p>
                <p>This website was created by Will and Alex, two highschoolers deeply interested in the relating fields. It is their goal to spread knowledge pertaining to the many intriguing facets of both Mathematics and Computer Science.</p>
            </div>
            <div className="media">
                <div className="image">
                    <img src="mathinfologo.png" alt="The MathInfo logo."/>
                    <p>The MathInfo logo.</p>
                </div>
            </div>
        </div>
            );
}
*/