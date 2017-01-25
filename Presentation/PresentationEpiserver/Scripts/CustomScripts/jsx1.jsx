var Hello = React.createClass({
    render: function() {
        var names = ['Jake', 'Jon', 'Thruster'];
        return (
        	<ul>
        		{names.map(function(name, index){
        		    return <li key={ index }>{name}</li>;
        		})}
        	</ul>
        )
    }
});
 
ReactDOM.render(<Hello />, document.getElementById('react-app'));