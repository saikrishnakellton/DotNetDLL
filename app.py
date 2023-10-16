from flask import Flask, render_template, request, jsonify
from flask_wtf import FlaskForm
from wtforms import FileField, SelectField, StringField, SubmitField
import clr
import os
from datetime import datetime
import sys
app = Flask(__name__)
app.config['SECRET_KEY'] = 'your_secret_key'

class UploadForm(FlaskForm):
    file = FileField('Upload File')
    submit = SubmitField('Submit')


class DataForm(FlaskForm):
    dropdown1 = SelectField('Dropdown 1')
    dropdown2 = SelectField('Dropdown 2')
    input_text = StringField('Input Text')
    submit = SubmitField('Submit Data')


@app.route('/', methods=['GET', 'POST'])
def index():
    upload_form = UploadForm()
    data_form = DataForm()
    if request.method == 'POST':
        # Handle file upload and data processing here
        # For simplicity, let's assume the file contains lines of data separated by commas
        # You need to replace this with your actual data processing logic
        if 'file' not in request.files:
            return jsonify({'error': 'No file part'})
        file = request.files['file']
        current_time = datetime.now()

        # Format the time as a string
        time_string = current_time.strftime("%Y%m%d%H%M%S")
        file_path = os.path.join(os.getcwd(), 'uploads', time_string+file.filename)
        file.save(file_path)
        clr.AddReference(file_path)
        dropdown1_choices = list(set(dir(clr)))  # Unique values for dropdown 1
        upload_form.file.data = None  # Clear file field

        # Populate choices for Dropdown 1
        # data_form.dropdown1.choices = 
        dropdown_data = ['Select']
        dropdown_data.extend([choice for choice in dropdown1_choices if not choice.startswith("_")])
        return jsonify({'success': 'File uploaded successfully', 'dropdown1_data': dropdown_data, 'file_path':file_path})
    return render_template('index.html', upload_form=upload_form, data_form=data_form)

@app.route('/api/get_dropdown2_options', methods=['GET'])
def get_dropdown2_options():
    # Sample data for dropdown2 based on dropdown1 selection
    dropdown1_value = request.args.get('dropdown1_value', '')
    
    clr.AddReference(request.args['file_path'] )
    
    
    if dropdown1_value == 'Select':
        raise 'Please select a value'
    else:
        import pdb;pdb.set_trace()
        data  = getattr(clr, dropdown1_value)('1')

    # Return JSON response with dropdown2_options
    return jsonify({'data': ''})

@app.route('/api/submit_form', methods=['POST'])
def submit_form():
    try:
        data = request.get_json()

        # Simulate processing the form data
        result = {
            'dropdown1': data.get('dropdown1', ''),
            'dropdown2': data.get('dropdown2', ''),
            'message': 'Form submitted successfully!'
        }

        return jsonify(result)

    except Exception as e:
        return jsonify({'error': str(e)})
    
if __name__ == '__main__':
    app.run(debug=True)
